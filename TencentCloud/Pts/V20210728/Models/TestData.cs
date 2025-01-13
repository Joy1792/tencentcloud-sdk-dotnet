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

namespace TencentCloud.Pts.V20210728.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TestData : AbstractModel
    {
        
        /// <summary>
        /// 测试数据集所在的文件名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 测试数据集是否分片
        /// </summary>
        [JsonProperty("Split")]
        public bool? Split{ get; set; }

        /// <summary>
        /// 首行是否为参数名
        /// </summary>
        [JsonProperty("HeaderInFile")]
        public bool? HeaderInFile{ get; set; }

        /// <summary>
        /// 参数名数组
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HeaderColumns")]
        public string[] HeaderColumns{ get; set; }

        /// <summary>
        /// 文件行数
        /// </summary>
        [JsonProperty("LineCount")]
        public long? LineCount{ get; set; }

        /// <summary>
        /// 更新时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdatedAt")]
        public string UpdatedAt{ get; set; }

        /// <summary>
        /// 文件字节数
        /// </summary>
        [JsonProperty("Size")]
        public long? Size{ get; set; }

        /// <summary>
        /// 头部数据行
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HeadLines")]
        public string[] HeadLines{ get; set; }

        /// <summary>
        /// 尾部数据行
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TailLines")]
        public string[] TailLines{ get; set; }

        /// <summary>
        /// 文件类型
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 文件 ID
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Split", this.Split);
            this.SetParamSimple(map, prefix + "HeaderInFile", this.HeaderInFile);
            this.SetParamArraySimple(map, prefix + "HeaderColumns.", this.HeaderColumns);
            this.SetParamSimple(map, prefix + "LineCount", this.LineCount);
            this.SetParamSimple(map, prefix + "UpdatedAt", this.UpdatedAt);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamArraySimple(map, prefix + "HeadLines.", this.HeadLines);
            this.SetParamArraySimple(map, prefix + "TailLines.", this.TailLines);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
        }
    }
}

