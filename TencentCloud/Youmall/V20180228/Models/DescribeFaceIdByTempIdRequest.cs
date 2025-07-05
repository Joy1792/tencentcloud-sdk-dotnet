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

namespace TencentCloud.Youmall.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeFaceIdByTempIdRequest : AbstractModel
    {
        
        /// <summary>
        /// 优mall集团id，通过"指定身份标识获取客户门店列表"接口获取
        /// </summary>
        [JsonProperty("CompanyId")]
        public string CompanyId{ get; set; }

        /// <summary>
        /// 优mall店铺id，通过"指定身份标识获取客户门店列表"接口获取
        /// </summary>
        [JsonProperty("ShopId")]
        public long? ShopId{ get; set; }

        /// <summary>
        /// 临时id
        /// </summary>
        [JsonProperty("TempId")]
        public string TempId{ get; set; }

        /// <summary>
        /// 摄像头id
        /// </summary>
        [JsonProperty("CameraId")]
        public long? CameraId{ get; set; }

        /// <summary>
        /// pos机id
        /// </summary>
        [JsonProperty("PosId")]
        public string PosId{ get; set; }

        /// <summary>
        /// 图片url过期时间：在当前时间+PictureExpires秒后，图片url无法继续正常访问；单位s；默认值1*24*60*60（1天）
        /// </summary>
        [JsonProperty("PictureExpires")]
        public long? PictureExpires{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CompanyId", this.CompanyId);
            this.SetParamSimple(map, prefix + "ShopId", this.ShopId);
            this.SetParamSimple(map, prefix + "TempId", this.TempId);
            this.SetParamSimple(map, prefix + "CameraId", this.CameraId);
            this.SetParamSimple(map, prefix + "PosId", this.PosId);
            this.SetParamSimple(map, prefix + "PictureExpires", this.PictureExpires);
        }
    }
}

