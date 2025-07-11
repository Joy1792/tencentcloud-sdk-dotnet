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

namespace TencentCloud.Ses.V20201002.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EmailIdentity : AbstractModel
    {
        
        /// <summary>
        /// 发信域名
        /// </summary>
        [JsonProperty("IdentityName")]
        public string IdentityName{ get; set; }

        /// <summary>
        /// 验证类型，固定为DOMAIN
        /// </summary>
        [JsonProperty("IdentityType")]
        public string IdentityType{ get; set; }

        /// <summary>
        /// 是否已通过验证
        /// </summary>
        [JsonProperty("SendingEnabled")]
        public bool? SendingEnabled{ get; set; }

        /// <summary>
        /// 当前信誉等级
        /// </summary>
        [JsonProperty("CurrentReputationLevel")]
        public ulong? CurrentReputationLevel{ get; set; }

        /// <summary>
        /// 当日最高发信量
        /// </summary>
        [JsonProperty("DailyQuota")]
        public ulong? DailyQuota{ get; set; }

        /// <summary>
        /// 域名配置的独立ip
        /// </summary>
        [JsonProperty("SendIp")]
        public string[] SendIp{ get; set; }

        /// <summary>
        /// tag 标签
        /// </summary>
        [JsonProperty("TagList")]
        public TagList[] TagList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IdentityName", this.IdentityName);
            this.SetParamSimple(map, prefix + "IdentityType", this.IdentityType);
            this.SetParamSimple(map, prefix + "SendingEnabled", this.SendingEnabled);
            this.SetParamSimple(map, prefix + "CurrentReputationLevel", this.CurrentReputationLevel);
            this.SetParamSimple(map, prefix + "DailyQuota", this.DailyQuota);
            this.SetParamArraySimple(map, prefix + "SendIp.", this.SendIp);
            this.SetParamArrayObj(map, prefix + "TagList.", this.TagList);
        }
    }
}

