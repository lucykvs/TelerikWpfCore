using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThemingControl {
    public class ThemeInfo {

        public ThemeInfo(string themeName, string displayName, string color1, string color2, string color3) {
            this.ThemeName = themeName;
            this.DisplayName = displayName;
            this.AccentColors = new List<string>();
            this.AccentColors.Add(color1);
            this.AccentColors.Add(color2);
            this.AccentColors.Add(color3);
        }

        public string DisplayName { get; private set; }
        public string ThemeName { get; private set; }
        public List<string> AccentColors { get; private set; }
    }
}
