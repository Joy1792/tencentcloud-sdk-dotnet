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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetFaceIdResultRequest : AbstractModel
    {
        
        /// <summary>
        /// SDK人脸核身流程的标识。
        /// - 调用[GetFaceIdToken](https://cloud.tencent.com/document/product/1007/49198)接口时生成。
        /// </summary>
        [JsonProperty("FaceIdToken")]
        public string FaceIdToken{ get; set; }

        /// <summary>
        /// 是否需要拉取视频。
        /// - 默认false：不需要。
        /// </summary>
        [JsonProperty("IsNeedVideo")]
        public bool? IsNeedVideo{ get; set; }

        /// <summary>
        /// 是否需要拉取截帧。
        /// - 默认false：不需要。
        /// </summary>
        [JsonProperty("IsNeedBestFrame")]
        public bool? IsNeedBestFrame{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FaceIdToken", this.FaceIdToken);
            this.SetParamSimple(map, prefix + "IsNeedVideo", this.IsNeedVideo);
            this.SetParamSimple(map, prefix + "IsNeedBestFrame", this.IsNeedBestFrame);
        }
    }
}

