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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CallBackTemplateInfo : AbstractModel
    {
        
        /// <summary>
        /// 模板 ID。
        /// </summary>
        [JsonProperty("TemplateId")]
        public long? TemplateId{ get; set; }

        /// <summary>
        /// 模板名称。
        /// </summary>
        [JsonProperty("TemplateName")]
        public string TemplateName{ get; set; }

        /// <summary>
        /// 描述信息。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 开播回调 URL。
        /// </summary>
        [JsonProperty("StreamBeginNotifyUrl")]
        public string StreamBeginNotifyUrl{ get; set; }

        /// <summary>
        /// 混流回调 URL。(参数已弃用)。
        /// </summary>
        [JsonProperty("StreamMixNotifyUrl")]
        public string StreamMixNotifyUrl{ get; set; }

        /// <summary>
        /// 断流回调 URL。
        /// </summary>
        [JsonProperty("StreamEndNotifyUrl")]
        public string StreamEndNotifyUrl{ get; set; }

        /// <summary>
        /// 录制文件回调 URL。
        /// </summary>
        [JsonProperty("RecordNotifyUrl")]
        public string RecordNotifyUrl{ get; set; }

        /// <summary>
        /// 截图回调 URL。
        /// </summary>
        [JsonProperty("SnapshotNotifyUrl")]
        public string SnapshotNotifyUrl{ get; set; }

        /// <summary>
        /// 鉴黄回调 URL。
        /// </summary>
        [JsonProperty("PornCensorshipNotifyUrl")]
        public string PornCensorshipNotifyUrl{ get; set; }

        /// <summary>
        /// 回调的鉴权 key。
        /// </summary>
        [JsonProperty("CallbackKey")]
        public string CallbackKey{ get; set; }

        /// <summary>
        /// 推流异常回调 URL。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PushExceptionNotifyUrl")]
        public string PushExceptionNotifyUrl{ get; set; }

        /// <summary>
        /// 音频审核回调 URL。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AudioAuditNotifyUrl")]
        public string AudioAuditNotifyUrl{ get; set; }

        /// <summary>
        /// 录制异常回调 URL。
        /// </summary>
        [JsonProperty("RecordExceptionNotifyUrl")]
        public string RecordExceptionNotifyUrl{ get; set; }

        /// <summary>
        /// 录制异常回调级别，可选择：error: 错误。alarm: 告警。
        /// </summary>
        [JsonProperty("RecordExceptionLevels")]
        public string[] RecordExceptionLevels{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "TemplateName", this.TemplateName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "StreamBeginNotifyUrl", this.StreamBeginNotifyUrl);
            this.SetParamSimple(map, prefix + "StreamMixNotifyUrl", this.StreamMixNotifyUrl);
            this.SetParamSimple(map, prefix + "StreamEndNotifyUrl", this.StreamEndNotifyUrl);
            this.SetParamSimple(map, prefix + "RecordNotifyUrl", this.RecordNotifyUrl);
            this.SetParamSimple(map, prefix + "SnapshotNotifyUrl", this.SnapshotNotifyUrl);
            this.SetParamSimple(map, prefix + "PornCensorshipNotifyUrl", this.PornCensorshipNotifyUrl);
            this.SetParamSimple(map, prefix + "CallbackKey", this.CallbackKey);
            this.SetParamSimple(map, prefix + "PushExceptionNotifyUrl", this.PushExceptionNotifyUrl);
            this.SetParamSimple(map, prefix + "AudioAuditNotifyUrl", this.AudioAuditNotifyUrl);
            this.SetParamSimple(map, prefix + "RecordExceptionNotifyUrl", this.RecordExceptionNotifyUrl);
            this.SetParamArraySimple(map, prefix + "RecordExceptionLevels.", this.RecordExceptionLevels);
        }
    }
}

