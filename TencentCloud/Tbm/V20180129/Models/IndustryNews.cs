/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Tbm.V20180129.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IndustryNews : AbstractModel
    {
        
        /// <summary>
        /// 行业报道ID
        /// </summary>
        [JsonProperty("IndustryId")]
        public string IndustryId{ get; set; }

        /// <summary>
        /// 报道发表时间
        /// </summary>
        [JsonProperty("PubTime")]
        public string PubTime{ get; set; }

        /// <summary>
        /// 报道来源
        /// </summary>
        [JsonProperty("FromSite")]
        public string FromSite{ get; set; }

        /// <summary>
        /// 报道标题
        /// </summary>
        [JsonProperty("Title")]
        public string Title{ get; set; }

        /// <summary>
        /// 报道来源url
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 报道来源等级
        /// </summary>
        [JsonProperty("Level")]
        public ulong? Level{ get; set; }

        /// <summary>
        /// 热度值
        /// </summary>
        [JsonProperty("Hot")]
        public ulong? Hot{ get; set; }

        /// <summary>
        /// 报道标识
        /// </summary>
        [JsonProperty("Flag")]
        public ulong? Flag{ get; set; }

        /// <summary>
        /// 报道摘要
        /// </summary>
        [JsonProperty("Abstract")]
        public string Abstract{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IndustryId", this.IndustryId);
            this.SetParamSimple(map, prefix + "PubTime", this.PubTime);
            this.SetParamSimple(map, prefix + "FromSite", this.FromSite);
            this.SetParamSimple(map, prefix + "Title", this.Title);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "Hot", this.Hot);
            this.SetParamSimple(map, prefix + "Flag", this.Flag);
            this.SetParamSimple(map, prefix + "Abstract", this.Abstract);
        }
    }
}

