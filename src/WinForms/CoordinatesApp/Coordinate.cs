using System;

namespace CoordinatesApp
{
    /// <summary>
    /// Represents a coordinate point with ID, X, Y position, and optional label
    /// </summary>
    public class Coordinate
    {
        public string Id { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public string Label { get; set; }

        public Coordinate()
        {
            Id = string.Empty;
            X = 0.0;
            Y = 0.0;
            Label = string.Empty;
        }

        public Coordinate(string id, double x, double y, string label = "")
        {
            Id = id;
            X = x;
            Y = y;
            Label = label;
        }

        /// <summary>
        /// Returns a string representation of the coordinate for display in ListBox
        /// Format: "id — (x, y) [label]"
        /// </summary>
        public override string ToString()
        {
            string labelPart = string.IsNullOrWhiteSpace(Label) ? "" : $" [{Label}]";
            return $"{Id} — ({X}, {Y}){labelPart}";
        }
    }
}
