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

namespace TencentCloud.Tiia.V20190529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RecognizeCarResponse : AbstractModel
    {
        
        /// <summary>
        /// 汽车的四个矩形顶点坐标，如果图片中存在多辆车，则输出最大车辆的坐标。
        /// </summary>
        [JsonProperty("CarCoords")]
        public Coord[] CarCoords{ get; set; }

        /// <summary>
        /// 车辆属性识别的结果数组，如果识别到多辆车，则会输出每辆车的top1结果。
        /// </summary>
        [JsonProperty("CarTags")]
        public CarTagItem[] CarTags{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "CarCoords.", this.CarCoords);
            this.SetParamArrayObj(map, prefix + "CarTags.", this.CarTags);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

