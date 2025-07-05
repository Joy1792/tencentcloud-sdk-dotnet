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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CommonMixControlParams : AbstractModel
    {
        
        /// <summary>
        /// 取值范围[0,1]。
        /// 填1时，当参数中图层分辨率参数与视频实际分辨率不一致时，自动从视频中按图层设置的分辨率比例进行裁剪。
        /// </summary>
        [JsonProperty("UseMixCropCenter")]
        public long? UseMixCropCenter{ get; set; }

        /// <summary>
        /// 取值范围[0,1]
        /// 填1时，当InputStreamList中个数为1时，且OutputParams.OutputStreamType为1时，不执行取消操作，执行拷贝流操作
        /// </summary>
        [JsonProperty("AllowCopy")]
        public long? AllowCopy{ get; set; }

        /// <summary>
        /// 取值范围[0,1]
        /// 填1时，透传原始流的sei
        /// </summary>
        [JsonProperty("PassInputSei")]
        public long? PassInputSei{ get; set; }

        /// <summary>
        /// 取值范围[0,1]
        /// 填1时，图片输入中的透明通道生效。
        /// </summary>
        [JsonProperty("UsePictureTransparent")]
        public long? UsePictureTransparent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UseMixCropCenter", this.UseMixCropCenter);
            this.SetParamSimple(map, prefix + "AllowCopy", this.AllowCopy);
            this.SetParamSimple(map, prefix + "PassInputSei", this.PassInputSei);
            this.SetParamSimple(map, prefix + "UsePictureTransparent", this.UsePictureTransparent);
        }
    }
}

