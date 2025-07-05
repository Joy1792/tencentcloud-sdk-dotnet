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

namespace TencentCloud.Iai.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AnalyzeDenseLandmarksResponse : AbstractModel
    {
        
        /// <summary>
        /// 请求的图片宽度。
        /// </summary>
        [JsonProperty("ImageWidth")]
        public long? ImageWidth{ get; set; }

        /// <summary>
        /// 请求的图片高度。
        /// </summary>
        [JsonProperty("ImageHeight")]
        public long? ImageHeight{ get; set; }

        /// <summary>
        /// 稠密人脸关键点具体信息。
        /// </summary>
        [JsonProperty("DenseFaceShapeSet")]
        public DenseFaceShape[] DenseFaceShapeSet{ get; set; }

        /// <summary>
        /// 人脸识别服务所用的算法模型版本。本接口仅支持 “3.0“ 输入。
        /// </summary>
        [JsonProperty("FaceModelVersion")]
        public string FaceModelVersion{ get; set; }

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
            this.SetParamSimple(map, prefix + "ImageWidth", this.ImageWidth);
            this.SetParamSimple(map, prefix + "ImageHeight", this.ImageHeight);
            this.SetParamArrayObj(map, prefix + "DenseFaceShapeSet.", this.DenseFaceShapeSet);
            this.SetParamSimple(map, prefix + "FaceModelVersion", this.FaceModelVersion);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

