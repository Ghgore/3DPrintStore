import Downloads from "./downloads";

function Tiles(props) {
    return (
        <div class="items">
            <h2>{props.printable.name}</h2>
            <p>Tags: {props.printable.tags.map((tag) => <span key={props.printable.tags.indexOf(tag)}><span className="tag">{tag}</span>, </span>)} <span className="tag">...</span></p>
            <img src={ props.printable.imgURL } width="350" height="200" />
            <div class="item-footers">
                { props.printable.verified ? <p>Verified</p> : <p>Not Verified</p> }
                <Downloads num={ props.printable.downloads } />
                <p>{ props.printable.rating } Stars</p>
            </div>
        </div>
    )
}

export default Tiles;