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

namespace TencentCloud.Ame.V20190916.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DataInfo : AbstractModel
    {
        
        /// <summary>
        /// Song Name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 歌曲版本
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// 歌曲总时长（非试听时长）
        /// </summary>
        [JsonProperty("Duration")]
        public string Duration{ get; set; }

        /// <summary>
        /// 试听开始时间
        /// </summary>
        [JsonProperty("AuditionBegin")]
        public ulong? AuditionBegin{ get; set; }

        /// <summary>
        /// 试听结束时间
        /// </summary>
        [JsonProperty("AuditionEnd")]
        public ulong? AuditionEnd{ get; set; }

        /// <summary>
        /// 标签名称
        /// </summary>
        [JsonProperty("TagNames")]
        public string[] TagNames{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "AuditionBegin", this.AuditionBegin);
            this.SetParamSimple(map, prefix + "AuditionEnd", this.AuditionEnd);
            this.SetParamArraySimple(map, prefix + "TagNames.", this.TagNames);
        }
    }
}

