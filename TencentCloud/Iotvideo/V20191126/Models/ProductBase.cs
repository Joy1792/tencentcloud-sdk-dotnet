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

namespace TencentCloud.Iotvideo.V20191126.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProductBase : AbstractModel
    {
        
        /// <summary>
        /// 产品ID
        /// </summary>
        [JsonProperty("ProductId")]
        public string ProductId{ get; set; }

        /// <summary>
        /// 产器型号(APP产品,为APP包名)
        /// </summary>
        [JsonProperty("ProductModel")]
        public string ProductModel{ get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [JsonProperty("ProductName")]
        public string ProductName{ get; set; }

        /// <summary>
        /// 产品描述信息
        /// </summary>
        [JsonProperty("ProductDescription")]
        public string ProductDescription{ get; set; }

        /// <summary>
        /// 创建时间，UNIX 时间戳，单位秒
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// 物模型发布版本号,0代表物模型尚未发布
        /// </summary>
        [JsonProperty("IotModelRevision")]
        public ulong? IotModelRevision{ get; set; }

        /// <summary>
        /// 产品密钥
        /// </summary>
        [JsonProperty("SecretKey")]
        public string SecretKey{ get; set; }

        /// <summary>
        /// 设备功能码
        /// ypsxth : 音频双向通话;	
        /// spdxth : 视频单向通话(监控);
        /// NVR0824 : NVR设备,大于8路，小于等于24路;
        /// WifiKeepalive : Wifi保活(低功耗产品);
        /// Alexa : Alexa接入;
        /// Google : Google接入;
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FuncCode")]
        public string[] FuncCode{ get; set; }

        /// <summary>
        /// 产品类别，0 : 普通视频设备；1 : NVR设备
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProductCate")]
        public long? ProductCate{ get; set; }

        /// <summary>
        /// 产品地域
        /// China-Mainland（中国大陆）
        /// China-Hong Kong, Macao and Taiwan（港澳台地区）
        /// America（美国）
        /// Europe（欧洲）
        /// Other-Overseas（其他境外地区）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProductRegion")]
        public string ProductRegion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "ProductModel", this.ProductModel);
            this.SetParamSimple(map, prefix + "ProductName", this.ProductName);
            this.SetParamSimple(map, prefix + "ProductDescription", this.ProductDescription);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "IotModelRevision", this.IotModelRevision);
            this.SetParamSimple(map, prefix + "SecretKey", this.SecretKey);
            this.SetParamArraySimple(map, prefix + "FuncCode.", this.FuncCode);
            this.SetParamSimple(map, prefix + "ProductCate", this.ProductCate);
            this.SetParamSimple(map, prefix + "ProductRegion", this.ProductRegion);
        }
    }
}

