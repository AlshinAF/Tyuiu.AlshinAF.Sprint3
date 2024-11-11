using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AlshinAF.Sprint3.Task3.V19.Lib
{
    public class DataService : ISprint3Task3V19
    {
        public string ReplaceCharOnNum(string value, char replaceable, char replacement)
        {
            foreach (char chr in value)
            {
                if (chr == replaceable)
                {
                    value = value.Replace(chr, replacement);
                }
            }
            return value;

        }
    }
}
