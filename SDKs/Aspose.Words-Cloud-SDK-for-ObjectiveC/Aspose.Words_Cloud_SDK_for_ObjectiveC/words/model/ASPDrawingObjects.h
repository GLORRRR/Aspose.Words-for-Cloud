#import <Foundation/Foundation.h>
#import "ASPObject.h"

/**
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen
 * Do not edit the class manually.
 */

#import "ASPLink.h"
#import "ASPLinkElement.h"


@protocol ASPDrawingObjects
@end

@interface ASPDrawingObjects : ASPObject

@property(nonatomic) NSArray<ASPLinkElement>* list;

@property(nonatomic) ASPLink* link;

@end
