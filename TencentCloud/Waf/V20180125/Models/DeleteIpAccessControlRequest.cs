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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeleteIpAccessControlRequest : AbstractModel
    {
        
        /// <summary>
        /// 域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 删除的ip数组
        /// </summary>
        [JsonProperty("Items")]
        public string[] Items{ get; set; }

        /// <summary>
        /// 若IsId字段为True，则Items列表元素需为Id，否则为IP
        /// </summary>
        [JsonProperty("IsId")]
        public bool? IsId{ get; set; }

        /// <summary>
        /// 是否删除对应的域名下的所有黑/白IP名单，true表示全部删除，false表示只删除指定ip名单
        /// </summary>
        [JsonProperty("DeleteAll")]
        public bool? DeleteAll{ get; set; }

        /// <summary>
        /// 是否为多域名黑白名单
        /// </summary>
        [JsonProperty("SourceType")]
        public string SourceType{ get; set; }

        /// <summary>
        /// IP黑白名单类型，40为IP白名单，42为IP黑名单
        /// </summary>
        [JsonProperty("ActionType")]
        public ulong? ActionType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamArraySimple(map, prefix + "Items.", this.Items);
            this.SetParamSimple(map, prefix + "IsId", this.IsId);
            this.SetParamSimple(map, prefix + "DeleteAll", this.DeleteAll);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "ActionType", this.ActionType);
        }
    }
}

