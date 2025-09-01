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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PreviewLogStatistic : AbstractModel
    {
        
        /// <summary>
        /// 日志内容
        /// </summary>
        [JsonProperty("LogContent")]
        public string LogContent{ get; set; }

        /// <summary>
        /// 行号。从0开始
        /// </summary>
        [JsonProperty("LineNum")]
        public long? LineNum{ get; set; }

        /// <summary>
        /// 目标日志主题ID
        /// - 通过[获取日志主题列表](https://cloud.tencent.com/document/product/614/56454)获取日志主题Id。
        /// </summary>
        [JsonProperty("DstTopicId")]
        public string DstTopicId{ get; set; }

        /// <summary>
        /// 失败错误信息， 空字符串""表示正常
        /// </summary>
        [JsonProperty("FailReason")]
        public string FailReason{ get; set; }

        /// <summary>
        /// 日志时间，格式：`2024-05-07 17:13:17.105`
        /// 
        /// - 入参时无效
        /// - 出参时有效，为日志中的时间格式
        /// </summary>
        [JsonProperty("Time")]
        public string Time{ get; set; }

        /// <summary>
        /// 目标topic-name
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DstTopicName")]
        [System.Obsolete]
        public string DstTopicName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LogContent", this.LogContent);
            this.SetParamSimple(map, prefix + "LineNum", this.LineNum);
            this.SetParamSimple(map, prefix + "DstTopicId", this.DstTopicId);
            this.SetParamSimple(map, prefix + "FailReason", this.FailReason);
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamSimple(map, prefix + "DstTopicName", this.DstTopicName);
        }
    }
}

