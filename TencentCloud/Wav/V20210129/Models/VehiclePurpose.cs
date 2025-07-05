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

namespace TencentCloud.Wav.V20210129.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VehiclePurpose : AbstractModel
    {
        
        /// <summary>
        /// 购车用途code
        /// </summary>
        [JsonProperty("VehiclePurposeCode")]
        public string VehiclePurposeCode{ get; set; }

        /// <summary>
        /// 购车用途名称
        /// </summary>
        [JsonProperty("VehiclePurposeName")]
        public string VehiclePurposeName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VehiclePurposeCode", this.VehiclePurposeCode);
            this.SetParamSimple(map, prefix + "VehiclePurposeName", this.VehiclePurposeName);
        }
    }
}

