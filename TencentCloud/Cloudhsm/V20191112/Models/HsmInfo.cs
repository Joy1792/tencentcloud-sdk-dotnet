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

namespace TencentCloud.Cloudhsm.V20191112.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HsmInfo : AbstractModel
    {
        
        /// <summary>
        /// 加密机型号
        /// </summary>
        [JsonProperty("Model")]
        public string Model{ get; set; }

        /// <summary>
        /// 此类型的加密机所支持的VSM类型列表
        /// </summary>
        [JsonProperty("VsmTypes")]
        public VsmInfo[] VsmTypes{ get; set; }

        /// <summary>
        /// 加密机母机类型：virtualization、GHSM、EHSM、SHSM
        /// </summary>
        [JsonProperty("HsmType")]
        public string HsmType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Model", this.Model);
            this.SetParamArrayObj(map, prefix + "VsmTypes.", this.VsmTypes);
            this.SetParamSimple(map, prefix + "HsmType", this.HsmType);
        }
    }
}

