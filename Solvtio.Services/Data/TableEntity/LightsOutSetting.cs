using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LightsOut.Services.Data.TableEntity
{
    [Table("LightsOutSetting")]
    public class LightsOutSetting
    {
        public LightsOutSetting() { }
        public LightsOutSetting(string name, string value) : this()
        {
            SettingName = name;
            SettingValue = value;
        }

        [Key]
        [Required]
        public string SettingName { get; set; }

        public string SettingValue { get; set; }
    }
}
