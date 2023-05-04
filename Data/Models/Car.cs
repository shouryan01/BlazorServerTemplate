namespace BlazorServerTemplate.Data.Models {
    public class Car
    {
        public Guid Id { get; set; }
        public string? Manufacturer { get; set; }
        public string? Year { get; set; }
        public string? Name { get; set; }
        public string? Color { get; set; }
        public int? Mileage { get; set; }
    }
}