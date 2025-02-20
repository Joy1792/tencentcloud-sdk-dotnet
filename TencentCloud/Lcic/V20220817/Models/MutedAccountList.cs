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

namespace TencentCloud.Lcic.V20220817.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MutedAccountList : AbstractModel
    {
        
        /// <summary>
        /// 用户 ID
        /// </summary>
        [JsonProperty("MemberAccount")]
        public string MemberAccount{ get; set; }

        /// <summary>
        /// 禁言到的时间（使用 UTC 时间，即世界协调时间）
        /// </summary>
        [JsonProperty("MutedUntil")]
        public ulong? MutedUntil{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MemberAccount", this.MemberAccount);
            this.SetParamSimple(map, prefix + "MutedUntil", this.MutedUntil);
        }
    }
}

