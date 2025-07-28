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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateParameterTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// 模板名称，长度为1～60个字符，仅支持数字,英文大小写字母、中文以及特殊字符_-./()（）[]+=：:@
        /// </summary>
        [JsonProperty("TemplateName")]
        public string TemplateName{ get; set; }

        /// <summary>
        /// 数据库大版本号，例如：11，12，13。可通过[DescribeDBVersions](https://cloud.tencent.com/document/api/409/89018)接口获取
        /// </summary>
        [JsonProperty("DBMajorVersion")]
        public string DBMajorVersion{ get; set; }

        /// <summary>
        /// 数据库引擎，例如：postgresql，mssql_compatible
        /// </summary>
        [JsonProperty("DBEngine")]
        public string DBEngine{ get; set; }

        /// <summary>
        /// 参数模板描述，长度为0～60个字符，仅支持数字,英文大小写字母、中文以及特殊字符_-./()（）[]+=：:@
        /// </summary>
        [JsonProperty("TemplateDescription")]
        public string TemplateDescription{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TemplateName", this.TemplateName);
            this.SetParamSimple(map, prefix + "DBMajorVersion", this.DBMajorVersion);
            this.SetParamSimple(map, prefix + "DBEngine", this.DBEngine);
            this.SetParamSimple(map, prefix + "TemplateDescription", this.TemplateDescription);
        }
    }
}

