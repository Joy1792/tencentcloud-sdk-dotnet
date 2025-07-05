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

namespace TencentCloud.Cam.V20190116.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSafeAuthFlagResponse : AbstractModel
    {
        
        /// <summary>
        /// 登录保护设置
        /// </summary>
        [JsonProperty("LoginFlag")]
        public LoginActionFlag LoginFlag{ get; set; }

        /// <summary>
        /// 敏感操作保护设置
        /// </summary>
        [JsonProperty("ActionFlag")]
        public LoginActionFlag ActionFlag{ get; set; }

        /// <summary>
        /// 异地登录保护设置
        /// </summary>
        [JsonProperty("OffsiteFlag")]
        public OffsiteFlag OffsiteFlag{ get; set; }

        /// <summary>
        /// 是否提示信任设备：1: 提示  0: 不提示
        /// </summary>
        [JsonProperty("PromptTrust")]
        public ulong? PromptTrust{ get; set; }

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
            this.SetParamObj(map, prefix + "LoginFlag.", this.LoginFlag);
            this.SetParamObj(map, prefix + "ActionFlag.", this.ActionFlag);
            this.SetParamObj(map, prefix + "OffsiteFlag.", this.OffsiteFlag);
            this.SetParamSimple(map, prefix + "PromptTrust", this.PromptTrust);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

