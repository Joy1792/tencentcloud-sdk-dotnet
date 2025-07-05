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

namespace TencentCloud.Mrs.V20200910.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MedDoc : AbstractModel
    {
        
        /// <summary>
        /// 建议
        /// </summary>
        [JsonProperty("Advice")]
        public Advice Advice{ get; set; }

        /// <summary>
        /// 诊断结果
        /// </summary>
        [JsonProperty("Diagnosis")]
        public DiagCertItem[] Diagnosis{ get; set; }

        /// <summary>
        /// 疾病史
        /// </summary>
        [JsonProperty("DiseaseMedicalHistory")]
        public DiseaseMedicalHistory DiseaseMedicalHistory{ get; set; }

        /// <summary>
        /// 个人史
        /// </summary>
        [JsonProperty("PersonalMedicalHistory")]
        public PersonalMedicalHistory PersonalMedicalHistory{ get; set; }

        /// <summary>
        /// 婚孕史
        /// </summary>
        [JsonProperty("ObstericalMedicalHistory")]
        public ObstericalMedicalHistory ObstericalMedicalHistory{ get; set; }

        /// <summary>
        /// 家族史
        /// </summary>
        [JsonProperty("FamilyMedicalHistory")]
        public FamilyMedicalHistory FamilyMedicalHistory{ get; set; }

        /// <summary>
        /// 月经史
        /// </summary>
        [JsonProperty("MenstrualMedicalHistory")]
        public MenstrualMedicalHistory MenstrualMedicalHistory{ get; set; }

        /// <summary>
        /// 诊疗记录
        /// </summary>
        [JsonProperty("TreatmentRecord")]
        public TreatmentRecord TreatmentRecord{ get; set; }

        /// <summary>
        /// 数据在原PDF文件中的第几页
        /// </summary>
        [JsonProperty("Page")]
        public long? Page{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Advice.", this.Advice);
            this.SetParamArrayObj(map, prefix + "Diagnosis.", this.Diagnosis);
            this.SetParamObj(map, prefix + "DiseaseMedicalHistory.", this.DiseaseMedicalHistory);
            this.SetParamObj(map, prefix + "PersonalMedicalHistory.", this.PersonalMedicalHistory);
            this.SetParamObj(map, prefix + "ObstericalMedicalHistory.", this.ObstericalMedicalHistory);
            this.SetParamObj(map, prefix + "FamilyMedicalHistory.", this.FamilyMedicalHistory);
            this.SetParamObj(map, prefix + "MenstrualMedicalHistory.", this.MenstrualMedicalHistory);
            this.SetParamObj(map, prefix + "TreatmentRecord.", this.TreatmentRecord);
            this.SetParamSimple(map, prefix + "Page", this.Page);
        }
    }
}

