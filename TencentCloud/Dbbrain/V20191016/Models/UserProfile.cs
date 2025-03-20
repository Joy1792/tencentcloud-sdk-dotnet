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

namespace TencentCloud.Dbbrain.V20191016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UserProfile : AbstractModel
    {
        
        /// <summary>
        /// 配置的id。
        /// </summary>
        [JsonProperty("ProfileId")]
        public string ProfileId{ get; set; }

        /// <summary>
        /// 配置类型。
        /// </summary>
        [JsonProperty("ProfileType")]
        public string ProfileType{ get; set; }

        /// <summary>
        /// 配置级别，"User"或"Instance"。
        /// </summary>
        [JsonProperty("ProfileLevel")]
        public string ProfileLevel{ get; set; }

        /// <summary>
        /// 配置名称。
        /// </summary>
        [JsonProperty("ProfileName")]
        public string ProfileName{ get; set; }

        /// <summary>
        /// 配置详情。
        /// </summary>
        [JsonProperty("ProfileInfo")]
        public ProfileInfo ProfileInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProfileId", this.ProfileId);
            this.SetParamSimple(map, prefix + "ProfileType", this.ProfileType);
            this.SetParamSimple(map, prefix + "ProfileLevel", this.ProfileLevel);
            this.SetParamSimple(map, prefix + "ProfileName", this.ProfileName);
            this.SetParamObj(map, prefix + "ProfileInfo.", this.ProfileInfo);
        }
    }
}

