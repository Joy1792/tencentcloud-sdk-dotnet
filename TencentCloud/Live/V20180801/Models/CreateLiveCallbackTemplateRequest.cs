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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateLiveCallbackTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// 模板名称。
        /// 长度上限：255字节。
        /// 仅支持中文、英文、数字、_、-。
        /// </summary>
        [JsonProperty("TemplateName")]
        public string TemplateName{ get; set; }

        /// <summary>
        /// 描述信息。
        /// 长度上限：1024字节。
        /// 仅支持中文、英文、数字、_、-。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 开播回调 URL，
        /// 相关协议文档：[事件消息通知](/document/product/267/32744)。
        /// </summary>
        [JsonProperty("StreamBeginNotifyUrl")]
        public string StreamBeginNotifyUrl{ get; set; }

        /// <summary>
        /// 断流回调 URL，
        /// 相关协议文档：[事件消息通知](/document/product/267/32744)。
        /// </summary>
        [JsonProperty("StreamEndNotifyUrl")]
        public string StreamEndNotifyUrl{ get; set; }

        /// <summary>
        /// 录制文件回调 URL，
        /// 相关协议文档：[事件消息通知](/document/product/267/32744)。
        /// </summary>
        [JsonProperty("RecordNotifyUrl")]
        public string RecordNotifyUrl{ get; set; }

        /// <summary>
        /// 录制状态回调 URL ，
        /// 相关协议文档：[事件消息通知](/document/product/267/32744)。
        /// </summary>
        [JsonProperty("RecordStatusNotifyUrl")]
        public string RecordStatusNotifyUrl{ get; set; }

        /// <summary>
        /// 截图回调 URL，
        /// 相关协议文档：[事件消息通知](/document/product/267/32744)。
        /// </summary>
        [JsonProperty("SnapshotNotifyUrl")]
        public string SnapshotNotifyUrl{ get; set; }

        /// <summary>
        /// 鉴黄回调 URL ，
        /// 相关协议文档：[事件消息通知](/document/product/267/32741)。
        /// </summary>
        [JsonProperty("PornCensorshipNotifyUrl")]
        public string PornCensorshipNotifyUrl{ get; set; }

        /// <summary>
        /// 回调 Key，回调 URL 公用，回调签名详见事件消息通知文档。
        /// [事件消息通知](/document/product/267/32744)。
        /// </summary>
        [JsonProperty("CallbackKey")]
        public string CallbackKey{ get; set; }

        /// <summary>
        /// 参数已弃用。
        /// </summary>
        [JsonProperty("StreamMixNotifyUrl")]
        public string StreamMixNotifyUrl{ get; set; }

        /// <summary>
        /// 推流异常回调 URL。
        /// </summary>
        [JsonProperty("PushExceptionNotifyUrl")]
        public string PushExceptionNotifyUrl{ get; set; }

        /// <summary>
        /// 音频审核回调 URL。
        /// </summary>
        [JsonProperty("AudioAuditNotifyUrl")]
        public string AudioAuditNotifyUrl{ get; set; }

        /// <summary>
        /// 录制异常回调 URL。
        /// </summary>
        [JsonProperty("RecordExceptionNotifyUrl")]
        public string RecordExceptionNotifyUrl{ get; set; }

        /// <summary>
        /// 录制异常回调级别，可选择：error、warning、info。
        /// </summary>
        [JsonProperty("RecordExceptionLevels")]
        public string[] RecordExceptionLevels{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TemplateName", this.TemplateName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "StreamBeginNotifyUrl", this.StreamBeginNotifyUrl);
            this.SetParamSimple(map, prefix + "StreamEndNotifyUrl", this.StreamEndNotifyUrl);
            this.SetParamSimple(map, prefix + "RecordNotifyUrl", this.RecordNotifyUrl);
            this.SetParamSimple(map, prefix + "RecordStatusNotifyUrl", this.RecordStatusNotifyUrl);
            this.SetParamSimple(map, prefix + "SnapshotNotifyUrl", this.SnapshotNotifyUrl);
            this.SetParamSimple(map, prefix + "PornCensorshipNotifyUrl", this.PornCensorshipNotifyUrl);
            this.SetParamSimple(map, prefix + "CallbackKey", this.CallbackKey);
            this.SetParamSimple(map, prefix + "StreamMixNotifyUrl", this.StreamMixNotifyUrl);
            this.SetParamSimple(map, prefix + "PushExceptionNotifyUrl", this.PushExceptionNotifyUrl);
            this.SetParamSimple(map, prefix + "AudioAuditNotifyUrl", this.AudioAuditNotifyUrl);
            this.SetParamSimple(map, prefix + "RecordExceptionNotifyUrl", this.RecordExceptionNotifyUrl);
            this.SetParamArraySimple(map, prefix + "RecordExceptionLevels.", this.RecordExceptionLevels);
        }
    }
}

