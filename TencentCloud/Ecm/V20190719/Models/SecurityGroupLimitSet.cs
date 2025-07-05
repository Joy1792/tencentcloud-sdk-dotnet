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

namespace TencentCloud.Ecm.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SecurityGroupLimitSet : AbstractModel
    {
        
        /// <summary>
        /// 可创建安全组总数
        /// </summary>
        [JsonProperty("SecurityGroupLimit")]
        public long? SecurityGroupLimit{ get; set; }

        /// <summary>
        /// 安全组下的最大规则数
        /// </summary>
        [JsonProperty("SecurityGroupPolicyLimit")]
        public long? SecurityGroupPolicyLimit{ get; set; }

        /// <summary>
        /// 安全组下嵌套安全组规则数
        /// </summary>
        [JsonProperty("ReferedSecurityGroupLimit")]
        public long? ReferedSecurityGroupLimit{ get; set; }

        /// <summary>
        /// 单安全组关联实例数
        /// </summary>
        [JsonProperty("SecurityGroupInstanceLimit")]
        public long? SecurityGroupInstanceLimit{ get; set; }

        /// <summary>
        /// 实例关联安全组数
        /// </summary>
        [JsonProperty("InstanceSecurityGroupLimit")]
        public long? InstanceSecurityGroupLimit{ get; set; }

        /// <summary>
        /// 单安全组关联的模块数
        /// </summary>
        [JsonProperty("SecurityGroupModuleLimit")]
        public long? SecurityGroupModuleLimit{ get; set; }

        /// <summary>
        /// 模块关联的安全组数
        /// </summary>
        [JsonProperty("ModuleSecurityGroupLimit")]
        public long? ModuleSecurityGroupLimit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SecurityGroupLimit", this.SecurityGroupLimit);
            this.SetParamSimple(map, prefix + "SecurityGroupPolicyLimit", this.SecurityGroupPolicyLimit);
            this.SetParamSimple(map, prefix + "ReferedSecurityGroupLimit", this.ReferedSecurityGroupLimit);
            this.SetParamSimple(map, prefix + "SecurityGroupInstanceLimit", this.SecurityGroupInstanceLimit);
            this.SetParamSimple(map, prefix + "InstanceSecurityGroupLimit", this.InstanceSecurityGroupLimit);
            this.SetParamSimple(map, prefix + "SecurityGroupModuleLimit", this.SecurityGroupModuleLimit);
            this.SetParamSimple(map, prefix + "ModuleSecurityGroupLimit", this.ModuleSecurityGroupLimit);
        }
    }
}

