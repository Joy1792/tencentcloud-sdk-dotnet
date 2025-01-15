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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AddressTemplate : AbstractModel
    {
        
        /// <summary>
        /// IP地址模板名称。
        /// </summary>
        [JsonProperty("AddressTemplateName")]
        public string AddressTemplateName{ get; set; }

        /// <summary>
        /// IP地址模板实例唯一ID。
        /// </summary>
        [JsonProperty("AddressTemplateId")]
        public string AddressTemplateId{ get; set; }

        /// <summary>
        /// IP地址信息。
        /// </summary>
        [JsonProperty("AddressSet")]
        public string[] AddressSet{ get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 最后更新时间。
        /// </summary>
        [JsonProperty("UpdatedTime")]
        public string UpdatedTime{ get; set; }

        /// <summary>
        /// 带备注的IP地址信息。
        /// </summary>
        [JsonProperty("AddressExtraSet")]
        public AddressInfo[] AddressExtraSet{ get; set; }

        /// <summary>
        /// 标签键值对。	
        /// </summary>
        [JsonProperty("TagSet")]
        public Tag[] TagSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AddressTemplateName", this.AddressTemplateName);
            this.SetParamSimple(map, prefix + "AddressTemplateId", this.AddressTemplateId);
            this.SetParamArraySimple(map, prefix + "AddressSet.", this.AddressSet);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "UpdatedTime", this.UpdatedTime);
            this.SetParamArrayObj(map, prefix + "AddressExtraSet.", this.AddressExtraSet);
            this.SetParamArrayObj(map, prefix + "TagSet.", this.TagSet);
        }
    }
}

