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

namespace TencentCloud.Aca.V20210323.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PatientFamilyHistory : AbstractModel
    {
        
        /// <summary>
        /// 家族病史 如家族病史不能分开，可传入此字段
        /// </summary>
        [JsonProperty("FamilyDiseaseHistory")]
        public string FamilyDiseaseHistory{ get; set; }

        /// <summary>
        /// 关系
        /// </summary>
        [JsonProperty("Relation")]
        public string Relation{ get; set; }

        /// <summary>
        /// 当前情况
        /// </summary>
        [JsonProperty("CurrentSituation")]
        public string CurrentSituation{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FamilyDiseaseHistory", this.FamilyDiseaseHistory);
            this.SetParamSimple(map, prefix + "Relation", this.Relation);
            this.SetParamSimple(map, prefix + "CurrentSituation", this.CurrentSituation);
        }
    }
}

