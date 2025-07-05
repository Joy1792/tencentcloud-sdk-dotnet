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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAdaptiveDynamicStreamingTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// 自适应转码格式，取值范围：
        /// <li>HLS；</li>
        /// <li>MPEG-DASH。</li>
        /// </summary>
        [JsonProperty("Format")]
        public string Format{ get; set; }

        /// <summary>
        /// 自适应转码输出子流参数信息，最多输出10路子流。
        /// 注意：各个子流的帧率必须保持一致；如果不一致，采用第一个子流的帧率作为输出帧率。
        /// </summary>
        [JsonProperty("StreamInfos")]
        public AdaptiveStreamTemplate[] StreamInfos{ get; set; }

        /// <summary>
        /// <b>点播[应用](/document/product/266/14574) ID。从2023年12月25日起开通点播的客户，如访问点播应用中的资源（无论是默认应用还是新创建的应用），必须将该字段填写为应用 ID。</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// 模板名称，长度限制：64 个字符。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// DRM 方案类型，取值范围：
        /// <li>SimpleAES</li>
        /// <li>Widevine</li>
        /// <li>FairPlay</li>
        /// 默认值为空字符串，如果取值为空字符串，代表不对视频做 DRM 保护。
        /// </summary>
        [JsonProperty("DrmType")]
        public string DrmType{ get; set; }

        /// <summary>
        /// DRM 的密钥提供商，取值范围：
        /// <li>SDMC：华曦达；</li>
        /// <li>VOD：云点播。</li>
        /// 默认为 VOD 。
        /// </summary>
        [JsonProperty("DrmKeyProvider")]
        public string DrmKeyProvider{ get; set; }

        /// <summary>
        /// 是否禁止视频低码率转高码率，取值范围：
        /// <li>0：否，</li>
        /// <li>1：是。</li>
        /// 默认为否。
        /// </summary>
        [JsonProperty("DisableHigherVideoBitrate")]
        public ulong? DisableHigherVideoBitrate{ get; set; }

        /// <summary>
        /// 是否禁止视频分辨率转高分辨率，取值范围：
        /// <li>0：否，</li>
        /// <li>1：是。</li>
        /// 默认为否。
        /// </summary>
        [JsonProperty("DisableHigherVideoResolution")]
        public ulong? DisableHigherVideoResolution{ get; set; }

        /// <summary>
        /// 模板描述信息，长度限制：256 个字符。
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// 切片类型，当 Format 为 HLS 时有效，可选值：
        /// <li>ts：ts 切片；</li>
        /// <li>fmp4：fmp4 切片。</li>
        /// 默认值：ts。
        /// </summary>
        [JsonProperty("SegmentType")]
        public string SegmentType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Format", this.Format);
            this.SetParamArrayObj(map, prefix + "StreamInfos.", this.StreamInfos);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "DrmType", this.DrmType);
            this.SetParamSimple(map, prefix + "DrmKeyProvider", this.DrmKeyProvider);
            this.SetParamSimple(map, prefix + "DisableHigherVideoBitrate", this.DisableHigherVideoBitrate);
            this.SetParamSimple(map, prefix + "DisableHigherVideoResolution", this.DisableHigherVideoResolution);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "SegmentType", this.SegmentType);
        }
    }
}

