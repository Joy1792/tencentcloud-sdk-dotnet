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

namespace TencentCloud.Ds.V20180523.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SignContractByCoordinateRequest : AbstractModel
    {
        
        /// <summary>
        /// 模块名ContractMng
        /// </summary>
        [JsonProperty("Module")]
        public string Module{ get; set; }

        /// <summary>
        /// 操作名SignContractByCoordinate
        /// </summary>
        [JsonProperty("Operation")]
        public string Operation{ get; set; }

        /// <summary>
        /// 合同ID
        /// </summary>
        [JsonProperty("ContractResId")]
        public string ContractResId{ get; set; }

        /// <summary>
        /// 帐户ID
        /// </summary>
        [JsonProperty("AccountResId")]
        public string AccountResId{ get; set; }

        /// <summary>
        /// 签署坐标，坐标原点在文件左下角，坐标单位为磅，坐标不得超过合同文件边界
        /// </summary>
        [JsonProperty("SignLocations")]
        public SignLocation[] SignLocations{ get; set; }

        /// <summary>
        /// 授权时间（由平台自动填充）
        /// </summary>
        [JsonProperty("AuthorizationTime")]
        public string AuthorizationTime{ get; set; }

        /// <summary>
        /// 授权IP地址（由平台自动填充）
        /// </summary>
        [JsonProperty("Position")]
        public string Position{ get; set; }

        /// <summary>
        /// 签章ID
        /// </summary>
        [JsonProperty("SealResId")]
        public string SealResId{ get; set; }

        /// <summary>
        /// 选用证书类型：1  表示RSA证书， 2 表示国密证书， 参数不传时默认为1
        /// </summary>
        [JsonProperty("CertType")]
        public long? CertType{ get; set; }

        /// <summary>
        /// 签名图片，base64编码
        /// </summary>
        [JsonProperty("ImageData")]
        public string ImageData{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamSimple(map, prefix + "Operation", this.Operation);
            this.SetParamSimple(map, prefix + "ContractResId", this.ContractResId);
            this.SetParamSimple(map, prefix + "AccountResId", this.AccountResId);
            this.SetParamArrayObj(map, prefix + "SignLocations.", this.SignLocations);
            this.SetParamSimple(map, prefix + "AuthorizationTime", this.AuthorizationTime);
            this.SetParamSimple(map, prefix + "Position", this.Position);
            this.SetParamSimple(map, prefix + "SealResId", this.SealResId);
            this.SetParamSimple(map, prefix + "CertType", this.CertType);
            this.SetParamSimple(map, prefix + "ImageData", this.ImageData);
        }
    }
}

