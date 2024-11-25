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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RecordParams : AbstractModel
    {
        
        /// <summary>
        /// 录制模式：
        /// 1：单流录制，分别录制房间的订阅UserId的音频和视频，将录制文件上传至云存储；
        /// 2：合流录制，将房间内订阅UserId的音视频混录成一个音视频文件，将录制文件上传至云存储；
        /// </summary>
        [JsonProperty("RecordMode")]
        public ulong? RecordMode{ get; set; }

        /// <summary>
        /// 房间内持续没有主播的状态超过MaxIdleTime的时长，自动停止录制，单位：秒。默认值为 30 秒，该值需大于等于 5秒，且小于等于 86400秒(24小时)。
        /// </summary>
        [JsonProperty("MaxIdleTime")]
        public ulong? MaxIdleTime{ get; set; }

        /// <summary>
        /// 录制的媒体流类型：
        /// 0：录制音频+视频流（默认）;
        /// 1：仅录制音频流；
        /// 2：仅录制视频流，
        /// </summary>
        [JsonProperty("StreamType")]
        public ulong? StreamType{ get; set; }

        /// <summary>
        /// 指定订阅流白名单或者黑名单。
        /// </summary>
        [JsonProperty("SubscribeStreamUserIds")]
        public SubscribeStreamUserIds SubscribeStreamUserIds{ get; set; }

        /// <summary>
        /// 输出文件的格式（存储至COS等第三方存储时有效）。0：(默认)输出文件为hls格式。1：输出文件格式为hls+mp4。2：输出文件格式为hls+aac 。3：输出文件格式为mp4。4：输出文件格式为aac。
        /// 
        /// 存储到云点播VOD时此参数无效，存储到VOD时请通过TencentVod（https://cloud.tencent.com/document/api/647/44055#TencentVod）内的MediaType设置。
        /// </summary>
        [JsonProperty("OutputFormat")]
        public ulong? OutputFormat{ get; set; }

        /// <summary>
        /// 单流录制模式下，用户的音视频是否合并，0：单流音视频不合并（默认）。1：单流音视频合并成一个ts。合流录制此参数无需设置，默认音视频合并。
        /// </summary>
        [JsonProperty("AvMerge")]
        public ulong? AvMerge{ get; set; }

        /// <summary>
        /// 如果是aac或者mp4文件格式，超过长度限制后，系统会自动拆分视频文件。单位：分钟。默认为1440min（24h），取值范围为1-1440。【单文件限制最大为2G，满足文件大小 >2G 或录制时长度 > 24h任意一个条件，文件都会自动切分】
        /// Hls 格式录制此参数不生效。
        /// </summary>
        [JsonProperty("MaxMediaFileDuration")]
        public ulong? MaxMediaFileDuration{ get; set; }

        /// <summary>
        /// 指定录制主辅流，0：主流+辅流（默认）；1:主流；2:辅流。
        /// </summary>
        [JsonProperty("MediaId")]
        public ulong? MediaId{ get; set; }

        /// <summary>
        /// 上行视频停止时，录制的补帧类型，0：补最后一帧 1：补黑帧
        /// </summary>
        [JsonProperty("FillType")]
        public ulong? FillType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RecordMode", this.RecordMode);
            this.SetParamSimple(map, prefix + "MaxIdleTime", this.MaxIdleTime);
            this.SetParamSimple(map, prefix + "StreamType", this.StreamType);
            this.SetParamObj(map, prefix + "SubscribeStreamUserIds.", this.SubscribeStreamUserIds);
            this.SetParamSimple(map, prefix + "OutputFormat", this.OutputFormat);
            this.SetParamSimple(map, prefix + "AvMerge", this.AvMerge);
            this.SetParamSimple(map, prefix + "MaxMediaFileDuration", this.MaxMediaFileDuration);
            this.SetParamSimple(map, prefix + "MediaId", this.MediaId);
            this.SetParamSimple(map, prefix + "FillType", this.FillType);
        }
    }
}

