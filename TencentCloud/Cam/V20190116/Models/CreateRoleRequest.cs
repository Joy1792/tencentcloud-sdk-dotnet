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

    public class CreateRoleRequest : AbstractModel
    {
        
        /// <summary>
        /// 角色名称。长度为1~128个字符，可包含英文字母、数字和+=,.@-_。
        /// </summary>
        [JsonProperty("RoleName")]
        public string RoleName{ get; set; }

        /// <summary>
        /// 策略文档，示例：{"version":"2.0","statement":[{"action":"name/sts:AssumeRole","effect":"allow","principal":{"service":["cloudaudit.cloud.tencent.com","cls.cloud.tencent.com"]}}]}，principal用于指定角色的授权对象。获取该参数可参阅 获取角色详情（https://cloud.tencent.com/document/product/598/36221） 输出参数RoleInfo
        /// </summary>
        [JsonProperty("PolicyDocument")]
        public string PolicyDocument{ get; set; }

        /// <summary>
        /// 角色描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 是否允许登录 1 为允许 0 为不允许
        /// </summary>
        [JsonProperty("ConsoleLogin")]
        public ulong? ConsoleLogin{ get; set; }

        /// <summary>
        /// 申请角色临时密钥的最长有效期限制(范围：0~43200)
        /// </summary>
        [JsonProperty("SessionDuration")]
        public ulong? SessionDuration{ get; set; }

        /// <summary>
        /// 角色绑定标签
        /// </summary>
        [JsonProperty("Tags")]
        public RoleTags[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RoleName", this.RoleName);
            this.SetParamSimple(map, prefix + "PolicyDocument", this.PolicyDocument);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "ConsoleLogin", this.ConsoleLogin);
            this.SetParamSimple(map, prefix + "SessionDuration", this.SessionDuration);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

