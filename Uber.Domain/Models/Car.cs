using Uber.Domain.Contracts;

namespace UberApp.Domain;

public class Car : IFullEntity<long>
{
    public Car() { }

    public Car(long id, long userId, string brand, string model, string color, string plateNumber, int year)
    {
        Id = id;
        UserId = userId;
        Brand = brand;
        Model = model;
        Color = color;
        PlateNumber = plateNumber;
        Year = year;
        CreatedAt = DateTime.UtcNow;
        IsDeleted = false;
        DeletedAt = new DateTime(1900, 1, 1);
    }

    public long Id { get; set; }

    public long UserId { get; set; }

    public string Brand { get; set; } = string.Empty;

    public string Model { get; set; } = string.Empty;

    public string Color { get; set; } = string.Empty;

    public string PlateNumber { get; set; } = string.Empty;

    public int Year { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public bool IsDeleted { get; set; }

    public DateTime DeletedAt { get; set; }

    public string OwnerName { get; set; } = string.Empty;

    public static Car Create(
        long userId,
        string brand,
        string model,
        string color,
        string plateNumber,
        int year)
    {
        if (userId <= 0)
            throw new Exception("لطفا ابتدا یک کاربر را انتخاب نمایید");

        if (string.IsNullOrWhiteSpace(brand) || brand.Trim().Length < 2)
            throw new Exception("برند خودرو را درست وارد نمایید");

        if (string.IsNullOrWhiteSpace(model) || model.Trim().Length < 1)
            throw new Exception("مدل خودرو را درست وارد نمایید");

        if (string.IsNullOrWhiteSpace(color) || color.Trim().Length < 2)
            throw new Exception("رنگ خودرو را درست وارد نمایید");

        if (string.IsNullOrWhiteSpace(plateNumber))
            throw new Exception("شماره پلاک را درست وارد نمایید");

        if (year > 1405)
            throw new Exception("سال ساخت خودرو را درست وارد نمایید");

        return new Car
        {
            UserId = userId,
            Brand = brand.Trim(),
            Model = model.Trim(),
            Color = color.Trim(),
            PlateNumber = plateNumber.Trim(),
            Year = year,
            CreatedAt = DateTime.UtcNow,
            IsDeleted = false,
            DeletedAt = new DateTime(1900, 1, 1)
        };
    }

    public void UpdateBrand(string brand)
    {
        if (string.IsNullOrWhiteSpace(brand) || brand.Trim().Length < 2)
            throw new ArgumentException("برند خودرو را درست وارد نمایید.");

        Brand = brand.Trim();
    }

    public void UpdateModel(string model)
    {
        if (string.IsNullOrWhiteSpace(model))
            throw new ArgumentException("مدل خودرو را درست وارد نمایید.");

        Model = model.Trim();
    }

    public void UpdateColor(string color)
    {
        if (string.IsNullOrWhiteSpace(color) || color.Trim().Length < 2)
            throw new ArgumentException("رنگ خودرو را درست وارد نمایید.");

        Color = color.Trim();
    }

    public void UpdatePlateNumber(string plateNumber)
    {
        if (string.IsNullOrWhiteSpace(plateNumber) || plateNumber.Trim().Length < 5)
            throw new ArgumentException("شماره پلاک را درست وارد نمایید.");

        PlateNumber = plateNumber.Trim();
    }

    public void UpdateYear(int year)
    {
        int currentYear = DateTime.UtcNow.Year;
        if (year < 1980 || year > currentYear + 1)
            throw new ArgumentException("سال ساخت خودرو را درست وارد نمایید.");

        Year = year;
    }
}
