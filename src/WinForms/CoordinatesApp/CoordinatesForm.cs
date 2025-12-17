using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace CoordinatesApp
{
    public partial class CoordinatesForm : Form
    {
        private List<Coordinate> coordinates = new List<Coordinate>();
        private string appDirectory;
        private string savedataPath;
        private string defaultDataPath;

        public CoordinatesForm()
        {
            InitializeComponent();
            
            // Set up paths
            appDirectory = AppDomain.CurrentDomain.BaseDirectory;
            savedataPath = Path.Combine(appDirectory, "savedata.json");
            defaultDataPath = Path.Combine(appDirectory, "coordinates.json");
        }

        private void CoordinatesForm_Load(object sender, EventArgs e)
        {
            LoadData();
            RefreshListBox();
            UpdateStatus("Application loaded. Ready.");
        }

        private void LoadData()
        {
            try
            {
                // Try to load from savedata.json first
                if (File.Exists(savedataPath))
                {
                    string json = File.ReadAllText(savedataPath);
                    coordinates = JsonSerializer.Deserialize<List<Coordinate>>(json) ?? new List<Coordinate>();
                    UpdateStatus($"Loaded from savedata.json ({coordinates.Count} coordinates)");
                }
                // Fallback to coordinates.json
                else if (File.Exists(defaultDataPath))
                {
                    string json = File.ReadAllText(defaultDataPath);
                    coordinates = JsonSerializer.Deserialize<List<Coordinate>>(json) ?? new List<Coordinate>();
                    UpdateStatus($"Loaded from coordinates.json ({coordinates.Count} coordinates)");
                }
                else
                {
                    coordinates = new List<Coordinate>();
                    UpdateStatus("No data file found. Starting with empty list.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                coordinates = new List<Coordinate>();
            }
        }

        private void SaveData()
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                string json = JsonSerializer.Serialize(coordinates, options);
                File.WriteAllText(savedataPath, json);
                UpdateStatus($"Auto-saved to savedata.json ({coordinates.Count} coordinates)");
            }
            catch (Exception ex)
            {
                UpdateStatus($"Error saving: {ex.Message}");
            }
        }

        private void RefreshListBox()
        {
            int selectedIndex = listBoxCoords.SelectedIndex;
            listBoxCoords.Items.Clear();
            
            foreach (var coord in coordinates)
            {
                listBoxCoords.Items.Add(coord);
            }

            // Restore selection if possible
            if (selectedIndex >= 0 && selectedIndex < listBoxCoords.Items.Count)
            {
                listBoxCoords.SelectedIndex = selectedIndex;
            }
        }

        private void UpdateStatus(string message)
        {
            statusLabel.Text = message;
        }

        private bool ValidateInput(out string id, out double x, out double y, out string label, bool isUpdate = false, string currentId = null)
        {
            // Initialize out parameters
            id = string.Empty;
            x = 0.0;
            y = 0.0;
            label = string.Empty;

            id = txtId.Text.Trim();
            label = txtLabel.Text.Trim();

            // Validate ID
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("ID cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Check for duplicate ID
            string idToCheck = id;
            if (isUpdate)
            {
                // For update, allow same ID if it's the current item being edited
                if (id != currentId && coordinates.Any(c => c.Id == idToCheck))
                {
                    MessageBox.Show($"ID '{id}' already exists. Please use a unique ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else
            {
                // For add, check if ID already exists
                if (coordinates.Any(c => c.Id == idToCheck))
                {
                    MessageBox.Show($"ID '{id}' already exists. Please use a unique ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            // Validate X
            if (!double.TryParse(txtX.Text.Trim(), out x))
            {
                MessageBox.Show("X must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validate Y
            if (!double.TryParse(txtY.Text.Trim(), out y))
            {
                MessageBox.Show("Y must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ClearInputs()
        {
            txtId.Clear();
            txtX.Clear();
            txtY.Clear();
            txtLabel.Clear();
            listBoxCoords.ClearSelected();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInput(out string id, out double x, out double y, out string label))
            {
                var newCoord = new Coordinate(id, x, y, label);
                coordinates.Add(newCoord);
                RefreshListBox();
                SaveData();
                ClearInputs();
                UpdateStatus($"Added coordinate: {id}");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listBoxCoords.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a coordinate to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedCoord = coordinates[listBoxCoords.SelectedIndex];
            
            if (ValidateInput(out string id, out double x, out double y, out string label, isUpdate: true, currentId: selectedCoord.Id))
            {
                selectedCoord.Id = id;
                selectedCoord.X = x;
                selectedCoord.Y = y;
                selectedCoord.Label = label;
                
                RefreshListBox();
                SaveData();
                UpdateStatus($"Updated coordinate: {id}");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteSelectedCoordinate();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteSelectedCoordinate();
        }

        private void DeleteSelectedCoordinate()
        {
            if (listBoxCoords.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a coordinate to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedCoord = coordinates[listBoxCoords.SelectedIndex];
            var result = MessageBox.Show(
                $"Are you sure you want to delete coordinate '{selectedCoord.Id}'?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                coordinates.RemoveAt(listBoxCoords.SelectedIndex);
                RefreshListBox();
                SaveData();
                ClearInputs();
                UpdateStatus($"Deleted coordinate: {selectedCoord.Id}");
            }
        }

        private void listBoxCoords_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCoords.SelectedIndex >= 0)
            {
                var selectedCoord = coordinates[listBoxCoords.SelectedIndex];
                txtId.Text = selectedCoord.Id;
                txtX.Text = selectedCoord.X.ToString();
                txtY.Text = selectedCoord.Y.ToString();
                txtLabel.Text = selectedCoord.Label;
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JSON files (*.json)|*.json|CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.Title = "Import Coordinates";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string extension = Path.GetExtension(openFileDialog.FileName).ToLower();
                        List<Coordinate> importedCoords = null;

                        if (extension == ".json")
                        {
                            importedCoords = ImportFromJson(openFileDialog.FileName);
                        }
                        else if (extension == ".csv")
                        {
                            importedCoords = ImportFromCsv(openFileDialog.FileName);
                        }
                        else
                        {
                            MessageBox.Show("Unsupported file format. Please select a JSON or CSV file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        if (importedCoords != null && importedCoords.Count > 0)
                        {
                            coordinates = importedCoords;
                            RefreshListBox();
                            SaveData();
                            UpdateStatus($"Imported {coordinates.Count} coordinates from {Path.GetFileName(openFileDialog.FileName)}");
                            MessageBox.Show($"Successfully imported {coordinates.Count} coordinates.", "Import Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No valid coordinates found in the file.", "Import Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error importing file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private List<Coordinate> ImportFromJson(string filePath)
        {
            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Coordinate>>(json) ?? new List<Coordinate>();
        }

        private List<Coordinate> ImportFromCsv(string filePath)
        {
            var coords = new List<Coordinate>();
            var lines = File.ReadAllLines(filePath);
            
            int startIndex = 0;
            // Check if first line is header
            if (lines.Length > 0 && lines[0].ToLower().Contains("id"))
            {
                startIndex = 1;
            }

            for (int i = startIndex; i < lines.Length; i++)
            {
                var line = lines[i].Trim();
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                // Simple CSV parsing with quoted field support
                var parts = ParseCsvLine(line);
                if (parts.Length >= 3)
                {
                    string id = parts[0].Trim();
                    
                    // Validate ID is not empty
                    if (string.IsNullOrWhiteSpace(id))
                        continue;
                        
                    if (double.TryParse(parts[1].Trim(), out double x) && 
                        double.TryParse(parts[2].Trim(), out double y))
                    {
                        string label = parts.Length > 3 ? parts[3].Trim() : "";
                        coords.Add(new Coordinate(id, x, y, label));
                    }
                }
            }

            return coords;
        }

        private string[] ParseCsvLine(string line)
        {
            var result = new System.Collections.Generic.List<string>();
            var current = new StringBuilder();
            bool inQuotes = false;

            for (int i = 0; i < line.Length; i++)
            {
                char c = line[i];
                
                if (c == '"')
                {
                    inQuotes = !inQuotes;
                }
                else if (c == ',' && !inQuotes)
                {
                    result.Add(current.ToString());
                    current.Clear();
                }
                else
                {
                    current.Append(c);
                }
            }
            
            result.Add(current.ToString());
            return result.ToArray();
        }

        private void btnExportJson_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "JSON files (*.json)|*.json";
                saveFileDialog.Title = "Export Coordinates as JSON";
                saveFileDialog.FileName = "coordinates_export.json";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var options = new JsonSerializerOptions { WriteIndented = true };
                        string json = JsonSerializer.Serialize(coordinates, options);
                        File.WriteAllText(saveFileDialog.FileName, json);
                        UpdateStatus($"Exported {coordinates.Count} coordinates to JSON");
                        MessageBox.Show($"Successfully exported to {Path.GetFileName(saveFileDialog.FileName)}", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error exporting: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnExportCsv_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
                saveFileDialog.Title = "Export Coordinates as CSV";
                saveFileDialog.FileName = "coordinates_export.csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var sb = new StringBuilder();
                        sb.AppendLine("Id,X,Y,Label");
                        
                        foreach (var coord in coordinates)
                        {
                            // Escape label if it contains commas or quotes
                            string escapedLabel = EscapeCsvField(coord.Label);
                            sb.AppendLine($"{coord.Id},{coord.X},{coord.Y},{escapedLabel}");
                        }

                        File.WriteAllText(saveFileDialog.FileName, sb.ToString());
                        UpdateStatus($"Exported {coordinates.Count} coordinates to CSV");
                        MessageBox.Show($"Successfully exported to {Path.GetFileName(saveFileDialog.FileName)}", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error exporting: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private string EscapeCsvField(string field)
        {
            if (string.IsNullOrEmpty(field))
                return field;
                
            // If field contains comma, newline, or quote, wrap it in quotes and escape quotes
            if (field.Contains(",") || field.Contains("\n") || field.Contains("\""))
            {
                return $"\"{field.Replace("\"", "\"\"")}\"";
            }
            
            return field;
        }
    }
}
