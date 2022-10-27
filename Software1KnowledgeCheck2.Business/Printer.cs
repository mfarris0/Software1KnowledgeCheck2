using System.Text;

namespace Software1KnowledgeCheck2.Business
{
    public class Printer : ComputerHardware
    {
        public int PrintedPagesPerMinute { get; set; }

        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine($"Manufacturer: {Manufacturer}");
            text.AppendLine($"Model Number: {ModelNumber}");
            text.AppendLine($"Printed pages per minute: {PrintedPagesPerMinute}");
            return text.ToString();
        }
    }


}
