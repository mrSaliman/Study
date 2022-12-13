using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    internal class Automobile : Owner
    {
        public DateOnly ReleaseDate;
        public double Mileage;
        public String Model;
        public String BodyType;
        public DateOnly InspectionDate;

        public Automobile(DateOnly releaseDate, double mileage, String model, String bodyType, bool isUridic, DateOnly inspectionDate) : base(isUridic)
        {
            this.ReleaseDate = releaseDate;
            this.Mileage = mileage;
            this.Model = model;
            this.BodyType = bodyType;
            this.InspectionDate = inspectionDate;
        }

        public DateOnly NextInspectionDate
        {
            get
            {
                if (IsUridic) return this.InspectionDate.AddMonths(6);
                else if (this.InspectionDate.AddYears(2).Year - ReleaseDate.Year >= 10) return this.InspectionDate.AddYears(1);
                else return this.InspectionDate.AddYears(2);
            }
        }

        public override string ToString()
        {
            StringBuilder output = new();

            output.AppendLine($"Дата выпуска: {ReleaseDate}");
            output.AppendLine($"Пробег: {Mileage}");
            output.AppendLine($"Марка: {Model}");
            output.AppendLine($"Тип кузова: {BodyType}");
            output.AppendLine($"Владелец - юр. лицо: {IsUridic}");
            output.AppendLine($"Дата последнего прохождения техосмотра: {InspectionDate}");
            output.AppendLine($"Дата следующего прохождения техосмотра: {NextInspectionDate}");

            return output.ToString();
        }
    }
}
