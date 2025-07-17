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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateImageCacheRequest : AbstractModel
    {
        
        /// <summary>
        /// 用于制作镜像缓存的容器镜像列表
        /// </summary>
        [JsonProperty("Images")]
        public string[] Images{ get; set; }

        /// <summary>
        /// 实例所属子网 ID
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 实例所属 VPC ID
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 镜像缓存名称
        /// </summary>
        [JsonProperty("ImageCacheName")]
        public string ImageCacheName{ get; set; }

        /// <summary>
        /// 安全组 ID
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// 镜像仓库凭证数组
        /// </summary>
        [JsonProperty("ImageRegistryCredentials")]
        public ImageRegistryCredential[] ImageRegistryCredentials{ get; set; }

        /// <summary>
        /// 用来绑定容器实例的已有EIP
        /// </summary>
        [JsonProperty("ExistedEipId")]
        public string ExistedEipId{ get; set; }

        /// <summary>
        /// 是否为容器实例自动创建EIP，默认为false。若传true，则此参数和ExistedEipIds互斥
        /// </summary>
        [JsonProperty("AutoCreateEip")]
        public bool? AutoCreateEip{ get; set; }

        /// <summary>
        /// 自动创建EIP的可选参数。若传此参数，则会自动创建EIP。
        /// 另外此参数和ExistedEipIds互斥
        /// </summary>
        [JsonProperty("AutoCreateEipAttribute")]
        public EipAttribute AutoCreateEipAttribute{ get; set; }

        /// <summary>
        /// 镜像缓存的大小。默认为20 GiB。取值范围参考[云硬盘类型](https://cloud.tencent.com/document/product/362/2353)中的高性能云盘类型的大小限制。
        /// </summary>
        [JsonProperty("ImageCacheSize")]
        public ulong? ImageCacheSize{ get; set; }

        /// <summary>
        /// 镜像缓存保留时间天数，过期将会自动清理，默认为0，永不过期。
        /// </summary>
        [JsonProperty("RetentionDays")]
        public ulong? RetentionDays{ get; set; }

        /// <summary>
        /// 指定拉取镜像仓库的镜像时不校验证书。如["harbor.example.com"]。
        /// </summary>
        [JsonProperty("RegistrySkipVerifyList")]
        public string[] RegistrySkipVerifyList{ get; set; }

        /// <summary>
        /// 指定拉取镜像仓库的镜像时使用 HTTP 协议。如["harbor.example.com"]。
        /// </summary>
        [JsonProperty("RegistryHttpEndPointList")]
        public string[] RegistryHttpEndPointList{ get; set; }

        /// <summary>
        /// 自定义制作镜像缓存过程中容器实例的宿主机上的 DNS。如：
        /// "nameserver 4.4.4.4\nnameserver 8.8.8.8"
        /// </summary>
        [JsonProperty("ResolveConfig")]
        public string ResolveConfig{ get; set; }

        /// <summary>
        /// 腾讯云标签
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Images.", this.Images);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "ImageCacheName", this.ImageCacheName);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamArrayObj(map, prefix + "ImageRegistryCredentials.", this.ImageRegistryCredentials);
            this.SetParamSimple(map, prefix + "ExistedEipId", this.ExistedEipId);
            this.SetParamSimple(map, prefix + "AutoCreateEip", this.AutoCreateEip);
            this.SetParamObj(map, prefix + "AutoCreateEipAttribute.", this.AutoCreateEipAttribute);
            this.SetParamSimple(map, prefix + "ImageCacheSize", this.ImageCacheSize);
            this.SetParamSimple(map, prefix + "RetentionDays", this.RetentionDays);
            this.SetParamArraySimple(map, prefix + "RegistrySkipVerifyList.", this.RegistrySkipVerifyList);
            this.SetParamArraySimple(map, prefix + "RegistryHttpEndPointList.", this.RegistryHttpEndPointList);
            this.SetParamSimple(map, prefix + "ResolveConfig", this.ResolveConfig);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

