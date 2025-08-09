function Downloads(props) {
    if (props.num == 1) {
        return <p>1 Download</p>
    } else if (props.num >= 1000000000) {
        return <p>{ props.num / 1000000000 }B Downloads</p>
    } else if (props.num >= 1000000) {
        return <p>{ props.num / 1000000 }M Downloads</p>
    } else if (props.num >= 1000) {
        return <p>{ props.num / 1000 }K Downloads</p>
    } else {
        return <p>{ props.num } Downloads</p>
    }
}

export default Downloads;