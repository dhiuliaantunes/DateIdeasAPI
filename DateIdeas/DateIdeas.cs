using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DateIdeas
{
    public class DateIdeas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public int DateId { get; set; }
        public string Date { get; set; }
        public bool RainyDay { get; set; }
        public bool SunnyDay { get; set; }
    }
}
