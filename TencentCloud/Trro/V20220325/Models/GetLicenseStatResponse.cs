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

namespace TencentCloud.Trro.V20220325.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetLicenseStatResponse : AbstractModel
    {
        
        /// <summary>
        /// 有效授权
        /// </summary>
        [JsonProperty("Valid")]
        public long? Valid{ get; set; }

        /// <summary>
        /// 已绑定授权
        /// </summary>
        [JsonProperty("Bound")]
        public long? Bound{ get; set; }

        /// <summary>
        /// 未绑定授权
        /// </summary>
        [JsonProperty("UnBound")]
        public long? UnBound{ get; set; }

        /// <summary>
        /// 过期授权
        /// </summary>
        [JsonProperty("Expire")]
        public long? Expire{ get; set; }

        /// <summary>
        /// 当月用量超时授权个数
        /// </summary>
        [JsonProperty("MonthlyExpire")]
        public long? MonthlyExpire{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Valid", this.Valid);
            this.SetParamSimple(map, prefix + "Bound", this.Bound);
            this.SetParamSimple(map, prefix + "UnBound", this.UnBound);
            this.SetParamSimple(map, prefix + "Expire", this.Expire);
            this.SetParamSimple(map, prefix + "MonthlyExpire", this.MonthlyExpire);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

