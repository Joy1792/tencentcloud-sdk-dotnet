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

namespace TencentCloud.Tiems.V20190416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QuantizationInput : AbstractModel
    {
        
        /// <summary>
        /// 量化输入路径
        /// </summary>
        [JsonProperty("InputPath")]
        public string InputPath{ get; set; }

        /// <summary>
        /// 量化输出路径
        /// </summary>
        [JsonProperty("OutputPath")]
        public string OutputPath{ get; set; }

        /// <summary>
        /// 量化批大小
        /// </summary>
        [JsonProperty("BatchSize")]
        public ulong? BatchSize{ get; set; }

        /// <summary>
        /// 量化精度，支持：FP32，FP16，INT8
        /// </summary>
        [JsonProperty("Precision")]
        public string Precision{ get; set; }

        /// <summary>
        /// 转换类型
        /// </summary>
        [JsonProperty("ConvertType")]
        public string ConvertType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InputPath", this.InputPath);
            this.SetParamSimple(map, prefix + "OutputPath", this.OutputPath);
            this.SetParamSimple(map, prefix + "BatchSize", this.BatchSize);
            this.SetParamSimple(map, prefix + "Precision", this.Precision);
            this.SetParamSimple(map, prefix + "ConvertType", this.ConvertType);
        }
    }
}

