using System.Text;

namespace ReplaceSqlParameters
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void replaceButton_Click(object sender, EventArgs e)
        {
            var parameters = richTextBoxParameters.Text.Split(',');
            Dictionary<string, string> parameterDictionary = new();
            foreach (var parameter in parameters)
            {
                var parameterKeyValues = parameter.Split('=');
                if (parameterKeyValues.Length != 2)
                {
                    throw new ArgumentException("List of parameters not valid format");
                }
                int numberHelper;
                bool isNumber = int.TryParse(parameterKeyValues[1].Replace("'", String.Empty), out numberHelper);
                if (isNumber)
                {
                    parameterDictionary.Add(parameterKeyValues[0].Trim(), parameterKeyValues[1].Replace("'", String.Empty));
                }
                else
                {
                    parameterDictionary.Add(parameterKeyValues[0].Trim(), parameterKeyValues[1]);
                }

            }

            StringBuilder stringBuilder = new(richTextBoxSql.Text);

            foreach (var parameterId in parameterDictionary.Keys.OrderByDescending(x => x.Length))
            {
                stringBuilder.Replace(parameterId, parameterDictionary[parameterId]);

            }

            richTextBoxResult.Text = stringBuilder.ToString();
        }
    }
}