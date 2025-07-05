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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TextVehicleBack : AbstractModel
    {
        
        /// <summary>
        /// 号牌号码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PlateNo")]
        public string PlateNo{ get; set; }

        /// <summary>
        /// 档案编号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FileNo")]
        public string FileNo{ get; set; }

        /// <summary>
        /// 核定人数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AllowNum")]
        public string AllowNum{ get; set; }

        /// <summary>
        /// 总质量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalMass")]
        public string TotalMass{ get; set; }

        /// <summary>
        /// 整备质量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CurbWeight")]
        public string CurbWeight{ get; set; }

        /// <summary>
        /// 核定载质量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LoadQuality")]
        public string LoadQuality{ get; set; }

        /// <summary>
        /// 外廓尺寸
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExternalSize")]
        public string ExternalSize{ get; set; }

        /// <summary>
        /// 备注
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Marks")]
        public string Marks{ get; set; }

        /// <summary>
        /// 检验记录
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Record")]
        public string Record{ get; set; }

        /// <summary>
        /// 准牵引总质量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalQuasiMass")]
        public string TotalQuasiMass{ get; set; }

        /// <summary>
        /// 副页编码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubPageCode")]
        public string SubPageCode{ get; set; }

        /// <summary>
        /// 燃料种类
        /// 
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FuelType")]
        public string FuelType{ get; set; }

        /// <summary>
        /// 住址
        /// </summary>
        [JsonProperty("AddressElectronic")]
        public string AddressElectronic{ get; set; }

        /// <summary>
        /// 发证机关
        /// </summary>
        [JsonProperty("IssueAuthorityElectronic")]
        public string IssueAuthorityElectronic{ get; set; }

        /// <summary>
        /// 车身颜色
        /// </summary>
        [JsonProperty("CarBodyColor")]
        public string CarBodyColor{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PlateNo", this.PlateNo);
            this.SetParamSimple(map, prefix + "FileNo", this.FileNo);
            this.SetParamSimple(map, prefix + "AllowNum", this.AllowNum);
            this.SetParamSimple(map, prefix + "TotalMass", this.TotalMass);
            this.SetParamSimple(map, prefix + "CurbWeight", this.CurbWeight);
            this.SetParamSimple(map, prefix + "LoadQuality", this.LoadQuality);
            this.SetParamSimple(map, prefix + "ExternalSize", this.ExternalSize);
            this.SetParamSimple(map, prefix + "Marks", this.Marks);
            this.SetParamSimple(map, prefix + "Record", this.Record);
            this.SetParamSimple(map, prefix + "TotalQuasiMass", this.TotalQuasiMass);
            this.SetParamSimple(map, prefix + "SubPageCode", this.SubPageCode);
            this.SetParamSimple(map, prefix + "FuelType", this.FuelType);
            this.SetParamSimple(map, prefix + "AddressElectronic", this.AddressElectronic);
            this.SetParamSimple(map, prefix + "IssueAuthorityElectronic", this.IssueAuthorityElectronic);
            this.SetParamSimple(map, prefix + "CarBodyColor", this.CarBodyColor);
        }
    }
}

