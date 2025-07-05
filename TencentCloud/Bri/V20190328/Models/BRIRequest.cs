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

namespace TencentCloud.Bri.V20190328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BRIRequest : AbstractModel
    {
        
        /// <summary>
        /// 业务名, 必须是以下六个业务名之一(bri_num,bri_dev,bri_ip_bri_apk,bri_url,bri_social)
        /// </summary>
        [JsonProperty("Service")]
        public string Service{ get; set; }

        /// <summary>
        /// QQ号 (业务名为bri_social时必填, 除非已填Wechat)
        /// </summary>
        [JsonProperty("QQ")]
        public string QQ{ get; set; }

        /// <summary>
        /// QQ号的可疑标签
        /// </summary>
        [JsonProperty("QQTag")]
        public string QQTag{ get; set; }

        /// <summary>
        /// 网址 (业务名为bri_url时必填)
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// Apk证书Md5  (业务名为bri_apk时必填，除非已填FileMd5)
        /// </summary>
        [JsonProperty("CertMd5")]
        public string CertMd5{ get; set; }

        /// <summary>
        /// Apk安装包名 (业务名为bri_apk时必填，除非已填FileMd5)
        /// </summary>
        [JsonProperty("PackageName")]
        public string PackageName{ get; set; }

        /// <summary>
        /// Apk文件Md5 (业务名为bri_apk时必填，除非已填PackageName,CertMd5,FileSize)
        /// </summary>
        [JsonProperty("FileMd5")]
        public string FileMd5{ get; set; }

        /// <summary>
        /// 业务场景 (1-注册, 2-登录, 3-发消息)
        /// </summary>
        [JsonProperty("Scene")]
        public string Scene{ get; set; }

        /// <summary>
        /// 电话号码 (业务名为bri_num时必填)
        /// </summary>
        [JsonProperty("PhoneNumber")]
        public string PhoneNumber{ get; set; }

        /// <summary>
        /// Apk文件大小  (业务名为bri_apk时必填，除非已填FileMd5)
        /// </summary>
        [JsonProperty("FileSize")]
        public long? FileSize{ get; set; }

        /// <summary>
        /// 点分格式的IP (业务名为bri_ip时必填)
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// 安卓设备的Imei (业务名为bri_dev时必填)
        /// </summary>
        [JsonProperty("Imei")]
        public string Imei{ get; set; }

        /// <summary>
        /// 微信号 (业务名为bri_social时必填, 除非已填QQ)
        /// </summary>
        [JsonProperty("Wechat")]
        public string Wechat{ get; set; }

        /// <summary>
        /// 微信号的可疑标签
        /// </summary>
        [JsonProperty("WechatTag")]
        public string WechatTag{ get; set; }

        /// <summary>
        /// 子客户ID
        /// </summary>
        [JsonProperty("SubAppid")]
        public string SubAppid{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Service", this.Service);
            this.SetParamSimple(map, prefix + "QQ", this.QQ);
            this.SetParamSimple(map, prefix + "QQTag", this.QQTag);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "CertMd5", this.CertMd5);
            this.SetParamSimple(map, prefix + "PackageName", this.PackageName);
            this.SetParamSimple(map, prefix + "FileMd5", this.FileMd5);
            this.SetParamSimple(map, prefix + "Scene", this.Scene);
            this.SetParamSimple(map, prefix + "PhoneNumber", this.PhoneNumber);
            this.SetParamSimple(map, prefix + "FileSize", this.FileSize);
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "Imei", this.Imei);
            this.SetParamSimple(map, prefix + "Wechat", this.Wechat);
            this.SetParamSimple(map, prefix + "WechatTag", this.WechatTag);
            this.SetParamSimple(map, prefix + "SubAppid", this.SubAppid);
        }
    }
}

