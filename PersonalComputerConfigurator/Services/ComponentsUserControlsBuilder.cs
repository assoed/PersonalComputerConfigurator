using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace PersonalComputerConfigurator.Services
{
    public static class UserControlBuilder
    {
        public static UserControl Create(object model)
        {
            var control = new UserControl
            {
                Size = new Size(500, 150), // Размеры можно менять
                BackColor = Color.LightGray,
                Padding = new Padding(5)
            };

            int verticalOffset = 10;

            // Проходимся по свойствам объекта
            foreach (var property in model.GetType().GetProperties())
            {
                var label = new Label
                {
                    Text = $"{property.Name}:",
                    Location = new Point(10, verticalOffset),
                    AutoSize = true
                };

                var value = property.GetValue(model);
                var valueLabel = new Label
                {
                    Text = value?.ToString() ?? "N/A",
                    Location = new Point(120, verticalOffset),
                    AutoSize = true
                };

                control.Controls.Add(label);
                control.Controls.Add(valueLabel);

                verticalOffset += 25;
            }

            return control;
        }
    }

}
