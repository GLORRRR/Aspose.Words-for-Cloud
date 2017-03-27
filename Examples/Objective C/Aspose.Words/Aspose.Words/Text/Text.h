//
//  Text.h
//  Aspose.Words
//
//  Created by Muhammad Sohail Ismail on 17/03/2017.
//  Copyright © 2017 Aspose. All rights reserved.
//

#import <Foundation/Foundation.h>
@class ASPWordsApi;

@interface Text : NSObject

@property(nonatomic, strong) ASPWordsApi *wordsApi;

- (void)getDocumentTextItems;
- (void)postReplaceText;

@end
