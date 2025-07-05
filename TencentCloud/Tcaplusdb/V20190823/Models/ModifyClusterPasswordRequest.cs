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

namespace TencentCloud.Tcaplusdb.V20190823.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyClusterPasswordRequest : AbstractModel
    {
        
        /// <summary>
        /// 需要修改密码的集群ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 集群旧密码
        /// </summary>
        [JsonProperty("OldPassword")]
        public string OldPassword{ get; set; }

        /// <summary>
        /// 集群旧密码预期失效时间
        /// </summary>
        [JsonProperty("OldPasswordExpireTime")]
        public string OldPasswordExpireTime{ get; set; }

        /// <summary>
        /// 集群新密码，密码必须是a-zA-Z0-9的字符,且必须包含数字和大小写字母
        /// </summary>
        [JsonProperty("NewPassword")]
        public string NewPassword{ get; set; }

        /// <summary>
        /// 更新模式： `1` 更新密码；`2` 更新旧密码失效时间，默认为`1` 模式
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "OldPassword", this.OldPassword);
            this.SetParamSimple(map, prefix + "OldPasswordExpireTime", this.OldPasswordExpireTime);
            this.SetParamSimple(map, prefix + "NewPassword", this.NewPassword);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
        }
    }
}

