using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Newtonsoft.Json;
using YiSha.Util;

namespace YiSha.Entity.ToolManage
{
    [Table("T_Birthday")]
    public class BirthdayeEntity: BaseExtensionEntity
    {
        public string  BirthDay { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string BirthdayName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime? Birthdaytime { get; set; }
    }
}
