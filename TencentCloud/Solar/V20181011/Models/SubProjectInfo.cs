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

namespace TencentCloud.Solar.V20181011.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SubProjectInfo : AbstractModel
    {
        
        /// <summary>
        /// 子项目id
        /// </summary>
        [JsonProperty("SubProjectId")]
        public string SubProjectId{ get; set; }

        /// <summary>
        /// 子项目名称
        /// </summary>
        [JsonProperty("SubProjectName")]
        public string SubProjectName{ get; set; }

        /// <summary>
        /// 子项目状态
        /// </summary>
        [JsonProperty("SubProjectStatus")]
        public string SubProjectStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubProjectId", this.SubProjectId);
            this.SetParamSimple(map, prefix + "SubProjectName", this.SubProjectName);
            this.SetParamSimple(map, prefix + "SubProjectStatus", this.SubProjectStatus);
        }
    }
}

