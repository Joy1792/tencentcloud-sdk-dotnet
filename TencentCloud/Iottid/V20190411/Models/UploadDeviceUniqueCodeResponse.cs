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

namespace TencentCloud.Iottid.V20190411.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UploadDeviceUniqueCodeResponse : AbstractModel
    {
        
        /// <summary>
        /// 本次已上传数量
        /// </summary>
        [JsonProperty("Count")]
        public ulong? Count{ get; set; }

        /// <summary>
        /// 重复的硬件唯一标识码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExistedCodeSet")]
        public string[] ExistedCodeSet{ get; set; }

        /// <summary>
        /// 剩余可上传数量
        /// </summary>
        [JsonProperty("LeftQuantity")]
        public ulong? LeftQuantity{ get; set; }

        /// <summary>
        /// 错误的硬件唯一标识码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IllegalCodeSet")]
        public string[] IllegalCodeSet{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamArraySimple(map, prefix + "ExistedCodeSet.", this.ExistedCodeSet);
            this.SetParamSimple(map, prefix + "LeftQuantity", this.LeftQuantity);
            this.SetParamArraySimple(map, prefix + "IllegalCodeSet.", this.IllegalCodeSet);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

