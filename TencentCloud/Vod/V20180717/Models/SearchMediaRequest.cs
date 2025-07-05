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

    public class SearchMediaRequest : AbstractModel
    {
        
        /// <summary>
        /// <b>点播[应用](/document/product/266/14574) ID。从2023年12月25日起开通点播的客户，如访问点播应用中的资源（无论是默认应用还是新创建的应用），必须将该字段填写为应用 ID。</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// 文件 ID 集合，匹配集合中的任意元素。
        /// <li>数组长度限制：10。</li>
        /// <li>单个 ID 长度限制：40个字符。</li>
        /// </summary>
        [JsonProperty("FileIds")]
        public string[] FileIds{ get; set; }

        /// <summary>
        /// 文件名集合，模糊匹配媒体文件的文件名，匹配度越高，排序越优先。
        /// <li>单个文件名长度限制：100个字符。</li>
        /// <li>数组长度限制：10。</li>
        /// </summary>
        [JsonProperty("Names")]
        public string[] Names{ get; set; }

        /// <summary>
        /// 文件名前缀，前缀匹配媒体文件的文件名。
        /// <li>单个文件名前缀长度限制：100个字符。</li>
        /// <li>数组长度限制：10。</li>
        /// </summary>
        [JsonProperty("NamePrefixes")]
        public string[] NamePrefixes{ get; set; }

        /// <summary>
        /// 文件描述集合，模糊匹配媒体文件的描述，匹配度越高，排序越优先。
        /// <li>单个描述长度限制：100个字符。</li>
        /// <li>数组长度限制：10。</li>
        /// </summary>
        [JsonProperty("Descriptions")]
        public string[] Descriptions{ get; set; }

        /// <summary>
        /// 分类 ID 集合，匹配集合指定 ID 的分类及其所有子类。
        /// <li>数组长度限制：10。</li>
        /// </summary>
        [JsonProperty("ClassIds")]
        public long?[] ClassIds{ get; set; }

        /// <summary>
        /// 标签集合，匹配集合中任意元素。
        /// <li>单个标签长度限制：32个字符。</li>
        /// <li>数组长度限制：16。</li>
        /// </summary>
        [JsonProperty("Tags")]
        public string[] Tags{ get; set; }

        /// <summary>
        /// 文件类型。匹配集合中的任意元素：
        /// <li>Video: 视频文件</li>
        /// <li>Audio: 音频文件</li>
        /// <li>Image: 图片文件</li>
        /// </summary>
        [JsonProperty("Categories")]
        public string[] Categories{ get; set; }

        /// <summary>
        /// 媒体文件来源集合，来源取值参见 [SourceType](https://cloud.tencent.com/document/product/266/31773#MediaSourceData)。
        /// <li>数组长度限制：10。</li>
        /// </summary>
        [JsonProperty("SourceTypes")]
        public string[] SourceTypes{ get; set; }

        /// <summary>
        /// 推流直播码集合。匹配集合中的任意元素。
        /// <li>数组长度限制：10。</li>
        /// </summary>
        [JsonProperty("StreamIds")]
        public string[] StreamIds{ get; set; }

        /// <summary>
        /// 匹配创建时间在此时间段内的文件。
        /// <li>包含所指定的头尾时间点。</li>
        /// </summary>
        [JsonProperty("CreateTime")]
        public TimeRange CreateTime{ get; set; }

        /// <summary>
        /// 匹配过期时间在此时间段内的文件，无法检索到已过期文件。
        /// <li>包含所指定的头尾时间点。</li>
        /// </summary>
        [JsonProperty("ExpireTime")]
        public TimeRange ExpireTime{ get; set; }

        /// <summary>
        /// 媒体文件存储地区，如 ap-chongqing，参见[地域列表](https://cloud.tencent.com/document/product/266/9760#.E5.B7.B2.E6.94.AF.E6.8C.81.E5.9C.B0.E5.9F.9F.E5.88.97.E8.A1.A8)。
        /// <li>单个存储地区长度限制：20个字符。</li>
        /// <li>数组长度限制：20。</li>
        /// </summary>
        [JsonProperty("StorageRegions")]
        public string[] StorageRegions{ get; set; }

        /// <summary>
        /// 存储类型数组。可选值有：
        /// <li> STANDARD：标准存储。</li>
        /// <li> STANDARD_IA：低频存储。</li>
        /// <li> ARCHIVE：归档存储。</li>
        /// <li> DEEP_ARCHIVE：深度归档存储。</li>
        /// </summary>
        [JsonProperty("StorageClasses")]
        public string[] StorageClasses{ get; set; }

        /// <summary>
        /// 媒体文件封装格式集合，匹配集合中任意元素。
        /// <li>数组长度限制：10。</li>
        /// </summary>
        [JsonProperty("MediaTypes")]
        public string[] MediaTypes{ get; set; }

        /// <summary>
        /// 媒体文件状态，匹配集合中任意元素。
        /// <li> Normal：正常；</li>
        /// <li> SystemForbidden：平台封禁；</li>
        /// <li> Forbidden：主动封禁。</li>
        /// </summary>
        [JsonProperty("Status")]
        public string[] Status{ get; set; }

        /// <summary>
        /// 媒体文件审核结果，匹配集合中任意元素。
        /// <li> pass：审核通过；</li>
        /// <li> review：疑似违规，建议复审；</li>
        /// <li> block：确认违规，建议封禁；</li>
        /// <li> notModerated：未审核。</li>
        /// </summary>
        [JsonProperty("ReviewResults")]
        public string[] ReviewResults{ get; set; }

        /// <summary>
        /// TRTC 应用 ID 集合。匹配集合中的任意元素。
        /// <li>数组长度限制：10。</li>
        /// </summary>
        [JsonProperty("TrtcSdkAppIds")]
        public ulong?[] TrtcSdkAppIds{ get; set; }

        /// <summary>
        /// TRTC 房间 ID 集合。匹配集合中的任意元素。
        /// <li>单个房间 ID 长度限制：64个字符；</li>
        /// <li>数组长度限制：10。</li>
        /// </summary>
        [JsonProperty("TrtcRoomIds")]
        public string[] TrtcRoomIds{ get; set; }

        /// <summary>
        /// 指定所有媒体文件需要返回的信息，可同时指定多个信息，N 从 0 开始递增。如果未填写该字段，默认返回所有信息。选项有：
        /// <li>basicInfo（视频基础信息）。</li>
        /// <li>metaData（视频元信息）。</li>
        /// <li>transcodeInfo（视频转码结果信息）。</li>
        /// <li>animatedGraphicsInfo（视频转动图结果信息）。</li>
        /// <li>imageSpriteInfo（视频雪碧图信息）。</li>
        /// <li>snapshotByTimeOffsetInfo（视频指定时间点截图信息）。</li>
        /// <li>sampleSnapshotInfo（采样截图信息）。</li>
        /// <li>keyFrameDescInfo（打点信息）。</li>
        /// <li>adaptiveDynamicStreamingInfo（转自适应码流信息）。</li>
        /// <li>miniProgramReviewInfo（小程序审核信息）。</li>
        /// </summary>
        [JsonProperty("Filters")]
        public string[] Filters{ get; set; }

        /// <summary>
        /// 排序方式。
        /// <li>Sort.Field 可选 CreateTime 。</li>
        /// <li>当 Text、 Names 或 Descriptions 不为空时，Sort.Field 字段无效， 搜索结果将以匹配度排序。</li>
        /// </summary>
        [JsonProperty("Sort")]
        public SortBy Sort{ get; set; }

        /// <summary>
        /// <div id="p_offset">分页返回的起始偏移量，默认值：0。将返回第 Offset 到第 Offset+Limit-1 条。
        /// <li>取值范围：Offset + Limit 不超过5000。（参见：<a href="#maxResultsDesc">接口返回结果数限制</a>）</li></div>
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// <div id="p_limit">分页返回的记录条数，默认值：10。将返回第 Offset 到第 Offset+Limit-1 条。
        /// <li>取值范围：Offset + Limit 不超过5000。（参见：<a href="#maxResultsDesc">接口返回结果数限制</a>）</li></div>
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// （不推荐：应使用 Names、NamePrefixes 或 Descriptions 替代）
        /// 搜索文本，模糊匹配媒体文件名称或描述信息，匹配项越多，匹配度越高，排序越优先。长度限制：64个字符。
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// （不推荐：应使用 SourceTypes 替代）
        /// 媒体文件来源，来源取值参见 [SourceType](https://cloud.tencent.com/document/product/266/31773#MediaSourceData)。
        /// </summary>
        [JsonProperty("SourceType")]
        public string SourceType{ get; set; }

        /// <summary>
        /// （不推荐：应使用 StreamIds 替代）
        /// 推流直播码。
        /// </summary>
        [JsonProperty("StreamId")]
        public string StreamId{ get; set; }

        /// <summary>
        /// （不推荐：应使用 CreateTime 替代）
        /// 创建时间的开始时间。
        /// <li>大于等于开始时间。</li>
        /// <li>当 CreateTime.After 也存在时，将优先使用 CreateTime.After。</li>
        /// <li>格式按照 ISO 8601标准表示，详见 [ISO 日期格式说明](https://cloud.tencent.com/document/product/266/11732#I)。</li>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// （不推荐：应使用 CreateTime 替代）
        /// 创建时间的结束时间。
        /// <li>小于结束时间。</li>
        /// <li>当 CreateTime.Before 也存在时，将优先使用 CreateTime.Before。</li>
        /// <li>格式按照 ISO 8601标准表示，详见 [ISO 日期格式说明](https://cloud.tencent.com/document/product/266/11732#I)。</li>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 该字段已无效。
        /// </summary>
        [JsonProperty("Vids")]
        public string[] Vids{ get; set; }

        /// <summary>
        /// 该字段已无效。
        /// </summary>
        [JsonProperty("Vid")]
        public string Vid{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamArraySimple(map, prefix + "FileIds.", this.FileIds);
            this.SetParamArraySimple(map, prefix + "Names.", this.Names);
            this.SetParamArraySimple(map, prefix + "NamePrefixes.", this.NamePrefixes);
            this.SetParamArraySimple(map, prefix + "Descriptions.", this.Descriptions);
            this.SetParamArraySimple(map, prefix + "ClassIds.", this.ClassIds);
            this.SetParamArraySimple(map, prefix + "Tags.", this.Tags);
            this.SetParamArraySimple(map, prefix + "Categories.", this.Categories);
            this.SetParamArraySimple(map, prefix + "SourceTypes.", this.SourceTypes);
            this.SetParamArraySimple(map, prefix + "StreamIds.", this.StreamIds);
            this.SetParamObj(map, prefix + "CreateTime.", this.CreateTime);
            this.SetParamObj(map, prefix + "ExpireTime.", this.ExpireTime);
            this.SetParamArraySimple(map, prefix + "StorageRegions.", this.StorageRegions);
            this.SetParamArraySimple(map, prefix + "StorageClasses.", this.StorageClasses);
            this.SetParamArraySimple(map, prefix + "MediaTypes.", this.MediaTypes);
            this.SetParamArraySimple(map, prefix + "Status.", this.Status);
            this.SetParamArraySimple(map, prefix + "ReviewResults.", this.ReviewResults);
            this.SetParamArraySimple(map, prefix + "TrtcSdkAppIds.", this.TrtcSdkAppIds);
            this.SetParamArraySimple(map, prefix + "TrtcRoomIds.", this.TrtcRoomIds);
            this.SetParamArraySimple(map, prefix + "Filters.", this.Filters);
            this.SetParamObj(map, prefix + "Sort.", this.Sort);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "StreamId", this.StreamId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArraySimple(map, prefix + "Vids.", this.Vids);
            this.SetParamSimple(map, prefix + "Vid", this.Vid);
        }
    }
}

