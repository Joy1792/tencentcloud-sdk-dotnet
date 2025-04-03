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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CLBMultiRegion : AbstractModel
    {
        
        /// <summary>
        /// 是否启用多可用区
        /// </summary>
        [JsonProperty("CLBMultiZoneFlag")]
        public bool? CLBMultiZoneFlag{ get; set; }

        /// <summary>
        /// 主可用区信息
        /// </summary>
        [JsonProperty("CLBMasterZone")]
        public string CLBMasterZone{ get; set; }

        /// <summary>
        /// 备可用区信息
        /// </summary>
        [JsonProperty("CLBSlaveZone")]
        public string CLBSlaveZone{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CLBMultiZoneFlag", this.CLBMultiZoneFlag);
            this.SetParamSimple(map, prefix + "CLBMasterZone", this.CLBMasterZone);
            this.SetParamSimple(map, prefix + "CLBSlaveZone", this.CLBSlaveZone);
        }
    }
}

