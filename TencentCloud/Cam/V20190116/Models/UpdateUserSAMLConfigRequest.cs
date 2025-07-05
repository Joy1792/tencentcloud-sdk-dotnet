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

namespace TencentCloud.Cam.V20190116.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateUserSAMLConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// 修改的操作类型:enable:启用,disable:禁用,updateSAML:修改元数据文档
        /// </summary>
        [JsonProperty("Operate")]
        public string Operate{ get; set; }

        /// <summary>
        /// 元数据文档，需要base64 encode，仅当Operate为updateSAML时需要此参数
        /// </summary>
        [JsonProperty("SAMLMetadataDocument")]
        public string SAMLMetadataDocument{ get; set; }

        /// <summary>
        /// 辅助域名
        /// </summary>
        [JsonProperty("AuxiliaryDomain")]
        public string AuxiliaryDomain{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Operate", this.Operate);
            this.SetParamSimple(map, prefix + "SAMLMetadataDocument", this.SAMLMetadataDocument);
            this.SetParamSimple(map, prefix + "AuxiliaryDomain", this.AuxiliaryDomain);
        }
    }
}

