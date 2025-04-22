/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RewriteTarget : AbstractModel
    {
        
        /// <summary>
        /// 重定向目标的监听器ID，该字段仅配置了重定向时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetListenerId")]
        public string TargetListenerId{ get; set; }

        /// <summary>
        /// 重定向目标的转发规则ID，该字段仅配置了重定向时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetLocationId")]
        public string TargetLocationId{ get; set; }

        /// <summary>
        /// 重定向状态码
        /// </summary>
        [JsonProperty("RewriteCode")]
        public long? RewriteCode{ get; set; }

        /// <summary>
        /// 重定向是否携带匹配的url
        /// </summary>
        [JsonProperty("TakeUrl")]
        public bool? TakeUrl{ get; set; }

        /// <summary>
        /// 重定向类型，Manual: 手动重定向，Auto:  自动重定向
        /// </summary>
        [JsonProperty("RewriteType")]
        public string RewriteType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TargetListenerId", this.TargetListenerId);
            this.SetParamSimple(map, prefix + "TargetLocationId", this.TargetLocationId);
            this.SetParamSimple(map, prefix + "RewriteCode", this.RewriteCode);
            this.SetParamSimple(map, prefix + "TakeUrl", this.TakeUrl);
            this.SetParamSimple(map, prefix + "RewriteType", this.RewriteType);
        }
    }
}

