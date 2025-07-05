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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateConfigTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// 配置模板名称
        /// </summary>
        [JsonProperty("ConfigTemplateName")]
        public string ConfigTemplateName{ get; set; }

        /// <summary>
        /// 配置模板对应的微服务框架
        /// </summary>
        [JsonProperty("ConfigTemplateType")]
        public string ConfigTemplateType{ get; set; }

        /// <summary>
        /// 配置模板数据
        /// </summary>
        [JsonProperty("ConfigTemplateValue")]
        public string ConfigTemplateValue{ get; set; }

        /// <summary>
        /// 配置模板描述
        /// </summary>
        [JsonProperty("ConfigTemplateDesc")]
        public string ConfigTemplateDesc{ get; set; }

        /// <summary>
        /// 无
        /// </summary>
        [JsonProperty("ProgramIdList")]
        public string[] ProgramIdList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConfigTemplateName", this.ConfigTemplateName);
            this.SetParamSimple(map, prefix + "ConfigTemplateType", this.ConfigTemplateType);
            this.SetParamSimple(map, prefix + "ConfigTemplateValue", this.ConfigTemplateValue);
            this.SetParamSimple(map, prefix + "ConfigTemplateDesc", this.ConfigTemplateDesc);
            this.SetParamArraySimple(map, prefix + "ProgramIdList.", this.ProgramIdList);
        }
    }
}

