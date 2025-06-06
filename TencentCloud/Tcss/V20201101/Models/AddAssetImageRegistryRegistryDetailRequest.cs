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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AddAssetImageRegistryRegistryDetailRequest : AbstractModel
    {
        
        /// <summary>
        /// 仓库名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [JsonProperty("Username")]
        public string Username{ get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// 仓库url
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 仓库类型，列表：harbor,quay,jfrog,aws,azure,other-tcr
        /// </summary>
        [JsonProperty("RegistryType")]
        public string RegistryType{ get; set; }

        /// <summary>
        /// 网络类型，列表：public（公网）
        /// </summary>
        [JsonProperty("NetType")]
        public string NetType{ get; set; }

        /// <summary>
        /// 仓库版本
        /// </summary>
        [JsonProperty("RegistryVersion")]
        public string RegistryVersion{ get; set; }

        /// <summary>
        /// 区域，列表：default（默认）
        /// </summary>
        [JsonProperty("RegistryRegion")]
        public string RegistryRegion{ get; set; }

        /// <summary>
        /// 限速
        /// </summary>
        [JsonProperty("SpeedLimit")]
        public long? SpeedLimit{ get; set; }

        /// <summary>
        /// 安全模式（证书校验）：0（默认） 非安全模式（跳过证书校验）：1
        /// </summary>
        [JsonProperty("Insecure")]
        public ulong? Insecure{ get; set; }

        /// <summary>
        /// 联通性检测的记录ID
        /// </summary>
        [JsonProperty("ConnDetectConfig")]
        public ConnDetectConfig[] ConnDetectConfig{ get; set; }

        /// <summary>
        /// 是否自动授权&扫描，选择全量同步时只针对最新版本镜像，增量同步时则包含所有新增镜像
        /// </summary>
        [JsonProperty("NeedScan")]
        public bool? NeedScan{ get; set; }

        /// <summary>
        /// 同步方式，0全量同步，1增量同步
        /// </summary>
        [JsonProperty("SyncMode")]
        public ulong? SyncMode{ get; set; }

        /// <summary>
        /// webhook接入地址
        /// </summary>
        [JsonProperty("WebhookUrl")]
        public string WebhookUrl{ get; set; }

        /// <summary>
        /// webhook接入token
        /// </summary>
        [JsonProperty("WebhookToken")]
        public string WebhookToken{ get; set; }

        /// <summary>
        /// tcr实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Username", this.Username);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "RegistryType", this.RegistryType);
            this.SetParamSimple(map, prefix + "NetType", this.NetType);
            this.SetParamSimple(map, prefix + "RegistryVersion", this.RegistryVersion);
            this.SetParamSimple(map, prefix + "RegistryRegion", this.RegistryRegion);
            this.SetParamSimple(map, prefix + "SpeedLimit", this.SpeedLimit);
            this.SetParamSimple(map, prefix + "Insecure", this.Insecure);
            this.SetParamArrayObj(map, prefix + "ConnDetectConfig.", this.ConnDetectConfig);
            this.SetParamSimple(map, prefix + "NeedScan", this.NeedScan);
            this.SetParamSimple(map, prefix + "SyncMode", this.SyncMode);
            this.SetParamSimple(map, prefix + "WebhookUrl", this.WebhookUrl);
            this.SetParamSimple(map, prefix + "WebhookToken", this.WebhookToken);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
        }
    }
}

