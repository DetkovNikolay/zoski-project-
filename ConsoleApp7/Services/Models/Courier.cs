using System.Collections.Generic;

namespace ParcelSorter.Models;

public class Courier
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public List<string> Streets { get; set; } = new();
    public double MaxWeightKg { get; set; }
    public ParcelSize MaxSize { get; set; }
    public bool SupportsCod { get; set; }

    public override string ToString()
    {
        var streets = string.Join(", ", Streets);
        return $"[{Id}] {Name} | Макс. вес: {MaxWeightKg} кг | Макс. размер: {MaxSize} | COD: {(SupportsCod ? "да" : "нет")} | Улицы: {streets}";
    }
}
