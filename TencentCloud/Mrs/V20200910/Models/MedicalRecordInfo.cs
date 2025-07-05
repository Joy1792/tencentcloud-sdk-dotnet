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

    public class MedicalRecordInfo : AbstractModel
    {
        
        /// <summary>
        /// 就诊日期
        /// </summary>
        [JsonProperty("DiagnosisTime")]
        public string DiagnosisTime{ get; set; }

        /// <summary>
        /// 就诊科室
        /// </summary>
        [JsonProperty("DiagnosisDepartmentName")]
        public string DiagnosisDepartmentName{ get; set; }

        /// <summary>
        /// 就诊医生
        /// </summary>
        [JsonProperty("DiagnosisDoctorName")]
        public string DiagnosisDoctorName{ get; set; }

        /// <summary>
        /// 临床诊断
        /// </summary>
        [JsonProperty("ClinicalDiagnosis")]
        public string ClinicalDiagnosis{ get; set; }

        /// <summary>
        /// 主述
        /// </summary>
        [JsonProperty("MainNarration")]
        public string MainNarration{ get; set; }

        /// <summary>
        /// 体格检查
        /// </summary>
        [JsonProperty("PhysicalExamination")]
        public string PhysicalExamination{ get; set; }

        /// <summary>
        /// 检查结论
        /// </summary>
        [JsonProperty("InspectionFindings")]
        public string InspectionFindings{ get; set; }

        /// <summary>
        /// 治疗意见
        /// </summary>
        [JsonProperty("TreatmentOpinion")]
        public string TreatmentOpinion{ get; set; }

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
            this.SetParamSimple(map, prefix + "DiagnosisTime", this.DiagnosisTime);
            this.SetParamSimple(map, prefix + "DiagnosisDepartmentName", this.DiagnosisDepartmentName);
            this.SetParamSimple(map, prefix + "DiagnosisDoctorName", this.DiagnosisDoctorName);
            this.SetParamSimple(map, prefix + "ClinicalDiagnosis", this.ClinicalDiagnosis);
            this.SetParamSimple(map, prefix + "MainNarration", this.MainNarration);
            this.SetParamSimple(map, prefix + "PhysicalExamination", this.PhysicalExamination);
            this.SetParamSimple(map, prefix + "InspectionFindings", this.InspectionFindings);
            this.SetParamSimple(map, prefix + "TreatmentOpinion", this.TreatmentOpinion);
            this.SetParamSimple(map, prefix + "Page", this.Page);
        }
    }
}

