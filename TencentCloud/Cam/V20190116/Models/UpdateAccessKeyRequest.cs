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

    public class UpdateAccessKeyRequest : AbstractModel
    {
        
        /// <summary>
        /// 指定需要更新的AccessKeyId
        /// </summary>
        [JsonProperty("AccessKeyId")]
        public string AccessKeyId{ get; set; }

        /// <summary>
        /// 密钥状态，激活（Active）或未激活（Inactive）
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 指定用户Uin，不填默认为当前用户更新访问密钥
        /// </summary>
        [JsonProperty("TargetUin")]
        public ulong? TargetUin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AccessKeyId", this.AccessKeyId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "TargetUin", this.TargetUin);
        }
    }
}

